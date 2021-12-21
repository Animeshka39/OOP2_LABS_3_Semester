from tkinter import *


class Main(Frame):
    def __init__(self, root):
        super(Main, self).__init__(root)
        self.build()

    def build(self):
        self.formula = "0"
        self.lbl = Label(text=self.formula, font=("Times New Roman", 21, "bold"), bg="#000", foreground="#00c800")
        self.lbl.place(x=11, y=10)

        btns = [
            "C", "DEL", "*", "=",
            "1", "2", "3", "/",
            "4", "5", "6", "+",
            "7", "8", "9", "-",
            "(", "0", ")", "X^2"
        ]

        x = 0
        y = 90
        for bt in btns:
            com = lambda x=bt: self.logicalc(x)
            Button(text=bt, bg="#000", foreground="#00c800",
                   font=("Times New Roman", 15),
                   command=com).place(x=x, y=y,
                                      width=50,
                                      height=70)
            x += 120
            if x > 370:
                x = 0
                y += 55

    def logicalc(self, operation):
        if operation == "C":
            self.formula = ""
        elif operation == "DEL":
            self.formula = self.formula[0:-1]
        elif operation == "X^2":
            self.formula = str((eval(self.formula))**2)
        elif operation == "=":
            self.formula = str(eval(self.formula))
        else:
            if self.formula == "0":
                self.formula = ""
            self.formula += operation
        self.update()

    def update(self):
        if self.formula == "":
            self.formula = "0"
        self.lbl.configure(text=self.formula)


if __name__ == '__main__':
    root = Tk()
    root["bg"] = "#000"
    root.geometry("410x380")
    root.title("Калькулятор")
    root.resizable(False, False)
    app = Main(root)
    app.pack()
    root.mainloop()
