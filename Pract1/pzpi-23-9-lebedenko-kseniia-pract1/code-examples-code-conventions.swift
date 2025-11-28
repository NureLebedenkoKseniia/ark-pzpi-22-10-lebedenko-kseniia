//
//  SwiftStandardsExamples.swift
//  Приклади коду з презентації "Правила оформлення коду Swift"
//

import XCTest

// MARK: - 1. Форматування (Formatting)
// Приклад правильних відступів та розміщення дужок (K&R style)

class PaymentManager {
    var maxAttempts: Int = 3
    
    // Correct Brace Style
    func processPayment() {
        if maxAttempts > 0 {
            print("Processing ... ")
        } else {
            print("Error")
        }
    }
}

// MARK: - 2. Іменування (Naming)
// Приклад іменування тестового методу (Unit of work + Input state + Expected outcome)

func test_operation_withCertainInputs_shouldDoSomething() {
    // implementation
}

// MARK: - 3. Коментування (Commenting)
// "Чому", а не "Що"

// BAD: Obvious comment
let i = 0 // Sets i to 0

// GOOD: Explains reasoning
// Using a lower timeout here because
// the user is waiting on the UI.
let timeout = 3.0

// MARK: - Helpers
private func setupUI() { 
    // ... 
}

// MARK: - 4. Документування (Documentation)
// Використання Markdown syntax

/// Calculates the total price including tax.
///
/// - Parameters:
///   - subtotal: The raw price of items.
///   - taxRate: The tax rate (e.g., 0.2 for 20%).
/// - Returns: The final price as Double.
func calculateTotal(
    subtotal: Double,
    taxRate: Double
) -> Double {
    return subtotal * (1 + taxRate)
}

// MARK: - 5. Тестування (TDD)
// Паттерн Given-When-Then

class CalculatorTests: XCTestCase {
    
    func testAddition_ShouldReturnSum() {
        // Given
        let calc = Calculator()
        
        // When
        let result = calc.add(2, 3)
        
        // Then
        XCTAssertEqual(result, 5)
    }
}

// Допоміжна заглушка для компіляції прикладу вище
class Calculator { func add(_ a: Int, _ b: Int) -> Int { return a + b } }


// MARK: - 6. Конфігурація лінтера (SwiftLint)
// Приклад вмісту файлу .swiftlint.yml

/*
 # .swiftlint.yml
 disabled_rules:
   - force_cast
 line_length: 120
*/


// MARK: - 7. Порівняння стилів (Bad vs Good)

// --- Поганий стиль (Bad Style) ---
/*
func f(u:User){
    if u.n != nil{
        save(u)
    }
}
let obj = 5 // magic number
*/

// --- Хороший стиль (Good Style) ---

func saveUser(_ user: User) {
    guard let name = user.name else {
        return
    }
    Database.save(user)
}
let maxRetries = 5

// Допоміжні заглушки для прикладів
struct User { var name: String?; var n: String? }
struct Database { static func save(_ user: User) {} }
