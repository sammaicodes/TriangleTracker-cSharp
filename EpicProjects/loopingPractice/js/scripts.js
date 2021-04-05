$(document).ready(function(){

  // ICE CREAM EXERCISE
  /////////////////////
  // let flavors = [
  //   "vanilla",
  //   "chocolate",
  //   "cookies",
  //   "strawberry"
  // ]

  // flavors.forEach(function(i) {
  //   if (i != "strawberry" ) {
  //     $("#pick").append(' ' + i +',')
  //   } else if (i === "strawberry") {
  //     $("#pick").append(' and ' + i + '.')
  //   } else {
  //     alert("Something went wrong!")
  //   }
  // })

  $("form#groceryForm").submit(function(event) {
    event.preventDefault()

    let groceries = []

    // Instead of listing each, do a forEach() loop:
    // .each() looks at "each" of a given element in the HTML
    // .forEach() looks at "each" of an ARRAY's elements
    $("input.item").each(function(i) {
      groceries[i] = $(this).val()
      // alert(groceries)
    })
    // alert(groceries)

    // Step 1: Alphabetize
    // First, go to lowercase
    // Then do .sort() to alphabetize
    let newGroceries = []
    let sortedGroceries;
    groceries.forEach(function(element){
      let grocery1 = element.toUpperCase()
      newGroceries.push(grocery1)
      sortedGroceries = newGroceries.sort()
    })
    alert(sortedGroceries)
    // Step 2: Make a new array
    // 
    // First, copy the lowercase array
    // Then turn this new array into uppercase
    
    // Step 3: Display uppercase, sorted list
    //
    // What we tried first:
    // $("ul#finalList").append("<li>" + sortedGroceries + "</li>")
    // This put the *whole* array "sortedGroceries" onto one <li>
    // So, we had to:
    // 1) Put it in a loop
    // 2) Break the array into elements
    // See below:
    sortedGroceries.forEach(function(element){
      $("ul#finalList").append("<li>" + element + "</li>")
    // end the loop!

    // Warm-up questions:
    // "How can we use square bracket notation to isolate a single element in an array?
    // What does this notation look like?"
    // someArray = [a, b, c, d, e]
    // How do you set a constant to equal just "e"?
    // const letter = ?
    // const letter = someArray[4]
    //
    // Array within an array:
    // someNewArray = [ [a, 1], [b, 2], [c, 3], [d, 4], [e, 5] ]
    // How to kinda visualize:
   //                = a   1
   //                  b   2
   //                  c   3
   //                  d   4
   //                  e   5
   //
   // How to select elements:
   // Select [b, 2] like this:
   // someNewArray[1]
   //
   // Select just "b" like this:
   // someNewArray[1][0]
   //
   // Select just "2" like this:
   // someNewArray[1][1]

    })

  })

})