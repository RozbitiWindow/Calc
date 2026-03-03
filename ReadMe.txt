# 🧮 Calc — Terminal Calculator

> A fast, lightweight calculator for quick math operations directly in your terminal.  
> Built with **C# / .NET 10** · Graphical GUI coming soon

---

## ✨ Features

- ⚡ Instant calculations without leaving the terminal
- 🔢 Supports basic arithmetic operations (`+`, `-`, `*`, `/`)
- 🐧 Linux-native terminal experience
- 🚀 Launch from anywhere via a simple alias

---

## 📦 Requirements

- [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0)
- Linux (Ubuntu, Debian, Arch, etc.)

---

## 🛠️ Installation

### 1. Clone the repository

```bash
git clone https://github.com/RozbitiWindow/Calc.git
cd Calc
```

### 2. Build the project

```bash
dotnet build
```

### 3. Set up the alias (run from anywhere)

Add the following line to your `~/.bashrc`:

```bash
echo 'alias bkcalc="cd /home/okno/calc && dotnet run && cd .."' >> ~/.bashrc
```

Then reload your shell configuration:

```bash
source ~/.bashrc
```

### 4. Run the calculator

```bash
bkcalc
```

---

## 🚀 Usage

After launching, simply type your expression and press **Enter**:

```
> 2 + 2
4

> 100 / 4
25

> 15 * 7
105
```

Type `exit` or press `Ctrl+C` to quit.

---

## 🗺️ Roadmap

- [x] Basic terminal calculator
- [x] Alias-based quick launch
- [ ] Graphical GUI (in progress)
- [ ] History of previous calculations
- [ ] Scientific mode (sin, cos, sqrt, ...)
- [ ] Expression parsing (e.g. `3 + 4 * 2`)

---

## 🤝 Contributing

Contributions are welcome! Feel free to open an [issue](https://github.com/RozbitiWindow/Calc/issues) or submit a pull request.

1. Fork the repository
2. Create your feature branch: `git checkout -b feature/my-feature`
3. Commit your changes: `git commit -m 'Add some feature'`
4. Push to the branch: `git push origin feature/my-feature`
5. Open a Pull Request

---

## 📄 License

This project is open source. See [LICENSE](LICENSE) for details.

---

<p align="center">Made with ❤️ by <a href="https://github.com/RozbitiWindow">RozbitiWindow</a></p>