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
* Demo1: Základní metody životního cyklu.
* Demo1Ref: Ukázka zapojení @ref do životního cyklu
* Demo2: Založení a ukončení instance, pokud již není potřeba (info o Visible="true/false") 
* Demo3: Volání při změně parametrů. Pokud se parametry nezmění, na komponentě se žádné kroky životního cyklu neodehrávají.
* Demo4: Předává CultureInfo. Ukázat, že DoNothing způsobí přerenderování komponenty
* Demo4: Ukázat SetParametersAsync - parameters.

## Životní cyklus s async/await

Zapnout async podobu.
V DemoComponent odkomentovat 3x await...

* Demo1: Základní metody životního cyklu. Nyní více ShouldRender, BuildRenderTree, AfterRender.
* Demo5: Ukázat renderování komponenty samotné na základě událostí.

## Životní cyklus s async/await II

* Demo6: Ukázat 

## Prerendering

Zapnout prerendering v App.razor.

* Demo1: Ukázat zduplikování událostí. Ale OnAfterRender.

## Takeaways / Otázky