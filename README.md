# Pyre – A Graphics Engine in OpenGL  

**Pyre** is a lightweight graphics engine built with **OpenGL, GLFW, GLAD, and GLM**, inspired by the concepts and techniques taught in the [LearnOpenGL](https://learnopengl.com/) book.  
It aims to provide a clear, modular, and educational implementation of modern rendering techniques, making it a great project for learning and experimenting with real-time graphics.  

---

## ✨ Features  

- **Core Rendering**: Built on modern OpenGL with GLFW for window/input handling, GLAD for function loading, and GLM for math operations.  
- **Lighting System**: Supports **Phong lighting** with ambient, diffuse, and specular components.  
- **Textures**: Implements **diffuse mapping** for realistic surface rendering.  
- **Extensible Architecture**: Designed for continuous development and expansion (e.g., normal mapping, PBR, shadow mapping).  
- **Educational**: Built step by step following LearnOpenGL, making the codebase beginner-friendly for anyone diving into graphics programming.  

---

## 🔧 Installation  

Clone the repository:  

```bash
git clone https://github.com/Open=Source-Chandigarh/pyre.git
cd pyre

Build using CMake:

mkdir build && cd build
cmake ..
make


Run the engine:

./pyre

🚀 Usage

Simply run the compiled binary to start the demo scene with current features (Phong lighting + diffuse textures).

As development continues, additional demos and scenes will be added to showcase new rendering techniques.

🤝 Contributing

Contributions, bug reports, and suggestions are welcome!
If you’d like to contribute, please read the CONTRIBUTING.md (coming soon).

📚 Learning Resource

This project is being developed alongside the LearnOpenGL
 guide, serving as a practical, code-based implementation of its concepts.

🙌 Credits

LearnOpenGL by Joey de Vries – The primary resource inspiring this engine.

OpenGL, GLFW, GLAD, GLM – Core libraries powering the engine.

📄 License

This project is licensed under the MIT License – see the LICENSE file for details.
