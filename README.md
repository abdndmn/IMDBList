# IMDb Film List Program

This project allows users to create and manage an IMDb film list. Users can add films with their IMDb scores, view all films, filter films based on their scores, and display films with titles starting with the letter 'A'.

---

## Features

### **1. Adding Films**
- Users can add films to the list by providing:
  - **Film Title**
  - **IMDb Score** (validated to be between 0 and 10).

### **2. Interactive Input**
- After adding each film, users are prompted to decide whether to add another film or stop the process.
- Valid responses for stopping: `hayır` or `hayir` (case-insensitive).

### **3. Displaying Films**
- **All Films**:
  - Displays all added films with their IMDb scores.
- **Filtered by IMDb Score**:
  - Displays films with IMDb scores between 4 and 9.
- **Titles Starting with 'A'**:
  - Lists films whose titles start with the letter 'A' (case-insensitive).

---

## Example Usage

### **Sample Input/Output**
#### Input:
```
IMDB Film listesine eklemek istediğiniz film adını giriniz:
Avatar
Lütfen eklediğiniz filmin IMDB puanını giriniz:
8.5
Daha fazla film eklemek için 'evet' yazınız, tamamladıysanız 'hayır' yazınız:
evet
IMDB Film listesine eklemek istediğiniz film adını giriniz:
Titanic
Lütfen eklediğiniz filmin IMDB puanını giriniz:
9.2
Daha fazla film eklemek için 'evet' yazınız, tamamladıysanız 'hayır' yazınız:
hayır
```

#### Output:
```
Tüm Filmler:
Film: Avatar, IMDB Puanı: 8.5
Film: Titanic, IMDB Puanı: 9.2

IMDB Puanı 4 ile 9 arasında olan Filmler:
Film: Avatar, IMDB Puanı: 8.5

İsmi 'A' ile başlayan Filmler:
Film: Avatar, IMDB Puanı: 8.5
```

---

## Code Structure

### **Class: Movies**
- **Properties**:
  - `MovieTitle`: Stores the name of the movie.
  - `ImdbScore`: Stores the IMDb score of the movie.

### **Main Program**
1. **Input Handling**:
   - Collects user input for movie details.
   - Validates IMDb scores to ensure they are between 0 and 10.
2. **List Operations**:
   - Stores movie objects in a list.
   - Allows dynamic addition of movies based on user input.
3. **Filters**:
   - Filters and displays:
     - All movies.
     - Movies with IMDb scores between 4 and 9.
     - Movies whose titles start with the letter 'A'.

---

## Concepts Demonstrated

### 1. **Object-Oriented Programming**
- Encapsulation through the `Movies` class.
- Use of properties for managing movie details.

### 2. **Input Validation**
- Ensures IMDb scores are between 0 and 10 using a `while` loop.

### 3. **String Operations**
- Case-insensitive checks for user input and title filtering.

### 4. **Collections**
- Utilizes a `List` to dynamically store movie objects.

---

## How to Extend

- Add more filters (e.g., movies with scores above a certain threshold).
- Include functionality for editing or removing movies.
- Save and load the movie list from a file.

---

This program is an excellent example of managing dynamic data in C# and showcases core programming concepts like loops, conditions, and object-oriented principles.

