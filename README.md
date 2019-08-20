# QRSS Viewer

**QRSS Viewer is an an open source QRSS spectrograph for Windows.** It is written in C#, makes heavy use of the [Spectrogram](https://github.com/swharden/Spectrogram) .NET library, and others are encouraged to modify it to their liking.

### QRSS Viewer is Similar to Argo

![](/dev/this-vs-argo.jpg)

### Features
* gain and AGC adjustments affect the whole window (not just new data)
* multiple colormaps (including viridis, ideal for this application)
* wide frequency window
  * vertical dimension is user-configurable (0-4kHz)
  * 300 Hz or less height is recommended for QRSS
  * the vertical scrollbar scrolls the whole window (not just new data)
* designed for QRSS stacking
  * Stacking means averaging several spectrograms together
  * spectrographs are always exactly 10 minutes wide
  * spectrographs always start at ten-minute marks
* configurable frequency resolution
  * default is ideal for QRSS
  * can be greatly increased to create dopplergrams
* multiple input sources
  * use the microphone to produce real-time images
  * use a WAV or MP3 file to rapidly analyze minutes or hours of audio
* GUI is optional
  * command line can accept WAV or MP3 and output an image
  * command line program works on Linux (.NET Core 3.0)

## Download
***This project is early in development. It is not ready to be used by the general public.***

## QRSS Resources

QRSS is a type of continuous wave (CW) radio signal which uses frequency-shift keying (FSK). QRSS is ultra-narrowband (5Hz bandwidth) and ultra slow speed (about 3 letters per minute). The abbreviation QRSS is [Morse code slang](https://en.wikipedia.org/wiki/Q_code) for "transmit a lot slower".

### Introduction to QRSS
  * [What is QRSS?](https://www.qsl.net/m0ayf/What-is-QRSS.html)
  * [QRSS and you](http://www.ka7oei.com/qrss1.html)
  * [QRSS (slow CW)](https://sites.google.com/site/qrssinfo/QRSS-Slow-CW)

### Technical Pages
  * [Simulation of QRSS Signals](https://www.qsl.net/pa2ohh/12qrsssim1.htm)

### Other QRSS Software

* Argo ([website](http://digilander.libero.it/i2phd/argo/)) - closed-source QRSS viewer for Windows
* SpectrumLab ([website](http://www.qsl.net/dl4yhf/spectra1.html)) - closed-source spectrum analyzer for Windows 
* QrssPIG ([gitlab](https://gitlab.com/hb9fxx/qrsspig)) - open-source spectrograph for Raspberry Pi (C++)
* Lopora ([website](http://www.qsl.net/pa2ohh/11lop.htm)) - open-source spectrograph (Python 3) 
* QRSS VD ([github](https://github.com/swharden/QRSS-VD)) - open source spectrograph (Python 2)

### QRSS Hardware
This repository is exclusively devoted to software. I run a separate repository dedicated to theory, design, construction, and testing of QRSS transmission and reception hardware:

https://github.com/swharden/QRSS-hardware