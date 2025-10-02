# Augmented Virtuality Framework for Sensory Analysis

This repository contains the reference implementation of an **Augmented Virtuality (AV) framework** developed for **consumer and sensory science applications**. The framework enables researchers to expose real-world elements through controlled virtual apertures while maintaining immersive environments.

The system was implemented in **Unity 6000.1.12f1** and validated on **Meta Quest 3** (full-color passthrough) and **Meta Quest 2** (grayscale passthrough). It can be extended to other passthrough-capable XR devices with similar APIs.

---

## Background

Augmented Virtuality (AV) occupies a midpoint on the Reality–Virtuality Continuum, where a virtual environment remains dominant but selectively reveals parts of the real world. In sensory science, ecological validity can be limited by artificial lab settings; AV helps balance immersion with authentic interaction by revealing physical stimuli within a controlled visual context. This allows presentation of real products (e.g., foods, utensils, instruments) while minimizing extraneous environmental cues, improving experimental control and reproducibility.

Conceptual foundation:
Zulkarnain, A. H. B., Moskowitz, H. R., Kókai, Z., & Gere, A. (2024). *Enhancing consumer sensory science approach through augmented virtuality.* Current Research in Food Science, 9, 100834.  
https://doi.org/10.1016/j.crfs.2024.100834

## Method Overview

The framework follows a **mask-and-reveal** approach:

- The virtual environment initializes as a **black field** (or an optional simple 3D room).
- **User-defined meshes** (e.g., circle, square, cylinder, cube) are used as *apertures*.
- These meshes are registered to the **OVR Passthrough Layer** for overlay composition.
- Live camera imagery (passthrough) appears **only within those apertures**.
- All other pixels remain virtual, ensuring deterministic confinement of real imagery.

This design preserves immersion while exposing only the required physical elements for a task or evaluation.

## Usage Instructions

### Requirements
- Unity 6000.1.12f1  
- Meta Quest 2 (grayscale passthrough) or Meta Quest 3 (full-color passthrough)  
- Android Build Support + XR Plugin Management

### Steps
1. Clone the repository:
   ```bash
   git clone https://github.com/matedigitalsensorylab/Raw_AV.git
   cd Raw_AV
2. Open the project in **Unity Hub** (6000.1.12f1).  
3. Ensure **OpenXR** and **Meta XR SDK** packages are installed.  
4. Switch Build Target to **Android**.  
5. **Build & Run** to your Quest device.

### Runtime
- The headset displays a black (or optional virtual room) environment.  
- Real-world elements appear only through the user-defined apertures.  
- No real imagery leaks outside these apertures.

--- 
## Resource Availability, Citation, Limitations

### Validation
The framework was tested in different runtime scenes:

- **Black field scene:** High-contrast apertures revealed real objects with no leakage outside defined meshes. Alignment and overlay composition remained stable during head motion.  
- **Immersive environment scene:** Apertures placed within a virtual room revealed real items while virtual walls and décor remained intact. Perspective shifts confirmed expected parallax and stable registration.

These observations support use in controlled sensory and consumer studies.

Resource Availability

The full Unity project is contained in this repository.

Large build files (.apk) may exceed GitHub’s recommended size limit. For distribution, consider GitHub Releases or Git LFS.

Citation

If this framework is useful in research, please cite:
Zulkarnain, A. H. B., Moskowitz, H. R., Kókai, Z., & Gere, A. (2024). Enhancing consumer sensory science approach through augmented virtuality. Current Research in Food Science, 9, 100834.
https://doi.org/10.1016/j.crfs.2024.100834

Limitations and Future Directions

This repository provides a baseline implementation. While effective for controlled exposure of real-world stimuli, further work can expand support for large panels, multimodal biometric integration (e.g., eye-tracking, GSR, heart rate), richer interaction toolkits, and more complex spatial layouts. The same principles may generalize beyond sensory analysis to training, therapy, and ergonomic evaluation.
