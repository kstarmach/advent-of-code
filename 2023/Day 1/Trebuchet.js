/// --- Part One --- ///
const fs = require('fs');

const filePath = './input.txt';

fs.readFile(filePath, 'utf8', (err, data) => {
    if (err) {
        console.error('Error reading file:', err);
        return;
    }

    // Split the file content into an array of lines
    const lines = data.split('\n');
    let result = 0;

    // Iterate over each line
    for (let line of lines) {
        // Skip processing empty lines or lines without digits
        if (line.trim() && (digits = line.replace(/\D/g, ''))) {
            // Check if there is only one digit in the line
            // If true, concatenate and parse, otherwise take the first and last digits
            result += (digits.length === 1) 
                ? parseInt(digits + digits) 
                : parseInt(digits[0] + digits[digits.length - 1]);
        }
    }

    // Output the final result
    console.log(result);
});