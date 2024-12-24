### **README.md**  

# 🎨 **Custom RadioButton in .NET MAUI**  
Learn how to create a modern and fully customizable `RadioButton` using .NET MAUI, `ControlTemplate`, and `VisualStateManager`.  

---

## 📹 **Video Tutorial**  
Watch the full step-by-step guide on YouTube:  
👉 [**How to Customize RadioButton in .NET MAUI**](https://youtu.be/WXFZZpXCtU4)  

---

## 🚀 **Overview**  
This project demonstrates how to:  
- Use a `ControlTemplate` to customize the appearance of a `RadioButton`.  
- Implement a `VisualStateManager` for dynamic style changes based on selection states.  
- Bind data dynamically using `BindableLayout` in XAML.  

---

## 📂 **Project Structure**  

```
SelectableOption/
├── Models/
│   └── ItemsControl.xaml
├── Views/
│   └── LandingPage.xaml
├── ViewModels/
│   ├── BaseViewModel.cs
│   └── LandingViewModel.cs
├── App.xaml.cs
└── App.xaml
```

---

## 🛠 **Setup Instructions**  

### Prerequisites  
1. .NET MAUI installed on your system.  
2. Visual Studio 2022 with MAUI workload.  

### Steps  
1. Clone the repository:  
   ```bash
   git clone https://github.com/your-username/SelectableOption.git
   cd SelectableOption
   ```  
2. Open the project in Visual Studio.  
3. Set the `LandingPage` as the MainPage in `App.xaml.cs`:  
   ```csharp
   MainPage = new Views.LandingPage();
   ```  
4. Run the project:  
   ```bash
   dotnet build
   dotnet run
   ```  

---

## 🖥 **Key Features**  

### **1. Customizable RadioButton Design**  
Uses `ControlTemplate` to define a clean and modern look for `RadioButton`.  

### **2. Visual State Management**  
Switches styles dynamically based on whether the option is selected (`Checked`) or not (`Unchecked`).  

### **3. Dynamic Data Binding**  
Populates the options dynamically from a ViewModel using `BindableLayout`.  

---

## 🎯 **What You'll Learn**  
- Leveraging `ControlTemplate` in XAML for reusability.  
- Creating visually appealing interfaces with `VisualStateManager`.  
- Using the MVVM pattern for clean and maintainable code.  

---

## 📝 **License**  
This project is licensed under the MIT License. Feel free to use and modify it for your own projects.  

---

## 💬 **Feedback**  
If you found this project helpful or have suggestions for improvement, please leave a comment on the YouTube video or open an issue in this repository.  

---

### **Connect with Me**  
- 💻 GitHub: [@your-username](https://github.com/brian593)  
- 📹 YouTube: [Watch Video](https://youtu.be/WXFZZpXCtU4)  
- 📧 Email: brian593@live.com  

Enjoy coding! 🚀
