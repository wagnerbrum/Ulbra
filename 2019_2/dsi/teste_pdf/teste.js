const PDFKit = require("pdfkit");
const fs = require("fs");

const pdf = new PDFKit({
    layout: "landscape"
});

const A4 = [595.28, 841.89];

const width = parseInt(pdf.page.width);
const height = parseInt(pdf.page.height);

pdf.image("teste_modelo.png", 0, 0, { height, width });

pdf.pipe(fs.createWriteStream("output.pdf"));
pdf.end();
