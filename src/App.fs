module App

open Fable.Core.JsInterop
open Fable.Import

let window = Browser.Dom.window
let myParagraph:Browser.Types.HTMLParagraphElement = unbox window.document.getElementById "myParagraph"

myParagraph.className <- "error"

printfn "page loaded"