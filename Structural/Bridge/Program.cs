
        // Export sales report as PDF
        Report sales = new SalesReport(new PdfExporter());
        sales.Export();

        // Export employee report as Excel
        Report employee = new EmployeeReport(new ExcelExporter());
        employee.Export();