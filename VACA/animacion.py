from ursina import *
import librosa
import numpy as np
import os
import pygame

AUDIO_FILE = "vaca_lola_cover.mp3"
MODELO_3D = "modelo_vaca.glb"

if not os.path.exists(AUDIO_FILE):
    print(f"\n[ERROR] No se encuentra el archivo: '{AUDIO_FILE}'")
    sys.exit()

app = Ursina()

window.title = "La Vaca Lola - Entorno 3D"
window.borderless = False

window.color = color.hex('#4CAF50')

suelo = Entity(
    model='plane',
    scale=(25, 1, 25),
    color=color.hex('#8B4513')  
)

vaca = Entity(
    model=MODELO_3D, 
    texture='white_cube', 
    scale=2, 
    y=0, 
    rotation_y=180
)
vaca.start_scale = vaca.scale

DirectionalLight(y=2, x=1, z=-3, shadows=True)

camara_libre = EditorCamera()

print("Analizando picos de ritmo del MP3...")
try:
    y, sr = librosa.load(AUDIO_FILE)
    tempo, beat_frames = librosa.beat.beat_track(y=y, sr=sr)
    beat_times = librosa.frames_to_time(beat_frames, sr=sr)
except Exception as e:
    beat_times = np.arange(0, 600, 60 / 120)

pygame.mixer.init()
pygame.mixer.music.load(AUDIO_FILE)
pygame.mixer.music.play()

beat_index = 0
balanceo_derecha = True

def update():
    global beat_index, balanceo_derecha
    
    tiempo_actual = pygame.mixer.music.get_pos() / 1000.0
    
    if beat_index < len(beat_times):
        if tiempo_actual >= beat_times[beat_index]:
            
            vaca.animate_y(0.5, duration=0.05, curve=curve.out_expo)
            invoke(lambda: vaca.animate_y(0, duration=0.1), delay=0.05)
            
            vaca.animate_scale(vaca.start_scale * 1.1, duration=0.05)
            invoke(lambda: vaca.animate_scale(vaca.start_scale, duration=0.1), delay=0.05)
            
            angulo_balanceo = 15 if balanceo_derecha else -15
            vaca.animate_rotation_z(angulo_balanceo, duration=0.05, curve=curve.out_expo)
            invoke(lambda: vaca.animate_rotation_z(0, duration=0.1), delay=0.1)
            
            vaca.animate_rotation_y(vaca.rotation_y + 45, duration=0.1, curve=curve.linear)
            
            balanceo_derecha = not balanceo_derecha
            beat_index += 1

app.run()