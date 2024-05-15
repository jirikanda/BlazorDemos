# Životní cyklus komponent

## Intro
* K čemu je dobré async/await?
* Co je to
    * Task.CompletedTask
    * Task.FromResult()
    * Task.Delay(...).
    * Task.Yield(...).

* ComponentBase

## Základní podoba životního cyklu
* Demo01: Základní metody životního cyklu.
* Demo02: Ukázka zapojení @ref do životního cyklu
* Demo03: Založení a ukončení instance, pokud již není potřeba (info o Visible="true/false") 
* Demo04: Volání při změně parametrů. Pokud se parametry nezmění, na komponentě se žádné kroky životního cyklu neodehrávají.
* Demo05: Předává CultureInfo. Ukázat, že DoNothing způsobí přerenderování komponenty
* Demo05: Ukázat SetParametersAsync - parameters.

## Životní cyklus s async/await

Zapnout async podobu.
V DemoComponent odkomentovat 3x await...

* Demo01: Základní metody životního cyklu. Nyní více ShouldRender, BuildRenderTree, AfterRender.
* Demo06: Ukázat renderování komponenty samotné na základě událostí.

## Životní cyklus s async/await II

* Demo07: Ukázat 

## Prerendering

Zapnout prerendering v App.razor.

* Demo01: Ukázat zduplikování událostí. Ale OnAfterRender.

## Takeaways / Otázky