(**

---
title: CSBar Report 1
category: CSBar Reports
categoryindex: 100
index: 0
---

*)

(**
<script src="https://cdn.plot.ly/plotly-latest.min.js"></script><style id="plotly.js-style-global"></style>
*)

(*** hide ***)

#r "nuget: Plotly.NET, 2.0.0-beta5"
open Plotly.NET

(**
# CSBar Report 1
_[Kevin Schneider](https://github.com/kMutagene)_

## Welcome to the first CSBar report! 
As you all know, our CSBar ticking system went live a few weeks ago.
Now that we sent out the first balance notifications, I decided that it's a good time to write the very first report and share an analysis of the coffe/beer/beverage consumption with you.

But first, I want to thank everyone participating. A whooping 100 % of coffees registered by the coffee machine have actually been ticked with our system, thanks for your patience during beta and your honesty.

I divided the analysis in 3 parts:

 1. [Summary Stats](#Summary-stats) � A summary of the time course of coffee, beer and beverage consumption and their fraction of the total consumption
 2. [Consumption Stats](#Consumption-stats) � Distributions of coffee, beer and beverage consumption over teams and the whole CSBar population
 3. [Distance Stats](#Distance-stats) � An analysis of the distances teams and their members traveled to get coffee

Analysis and plots where done by using the toolkits we develop. Feel free to take a look at our libraries at [Github](https://github.com/CSBiology), they are all open source and free to use.
All the charts are interactive, meaning you can zoom in/out etc.

## Summary stats

### Time course of consumption
The overall timecourse of the respective consumptions so far is not too suprising.
Coffee consumption is high during all weekdays and almost not present on weekends. Interestingly, there always seems to be somebody working in the building at weekends who needs a nice cup of coffee to get work done.
Beer consumption seems to be the highest on wednesdays (Bergfest!) and especially on fridays (weekend is coming, yay!). There also seem to be no parties in the social room at weekends, at least not with CSBar beer.
Beverage consumption peeks at Aug 28th, and the low consumption afterwards may be due to the missing afri cola, which was very delicious.  

<div id="e075b67b-a726-4a55-a26c-4be921c46433" style="width: 1000px; height: 750px;"><!-- Plotly chart will be drawn inside this DIV --></div>        
<script>
  var data = [{"type":"bar","x":["2018-08-17T00:00:00","2018-08-18T00:00:00","2018-08-19T00:00:00","2018-08-20T00:00:00","2018-08-21T00:00:00","2018-08-22T00:00:00","2018-08-23T00:00:00","2018-08-24T00:00:00","2018-08-25T00:00:00","2018-08-26T00:00:00","2018-08-27T00:00:00","2018-08-28T00:00:00","2018-08-29T00:00:00","2018-08-30T00:00:00","2018-08-31T00:00:00","2018-09-01T00:00:00","2018-09-02T00:00:00","2018-09-03T00:00:00","2018-09-04T00:00:00"],"y":[0,1,0,18,13,9,29,23,1,2,23,31,32,20,19,1,0,24,14],"marker":{},"name":"CoffeeConsumption","xaxis":"x","yaxis":"y"},{"type":"scatter","x":["2018-08-17T00:00:00","2018-08-18T00:00:00","2018-08-19T00:00:00","2018-08-20T00:00:00","2018-08-21T00:00:00","2018-08-22T00:00:00","2018-08-23T00:00:00","2018-08-24T00:00:00","2018-08-25T00:00:00","2018-08-26T00:00:00","2018-08-27T00:00:00","2018-08-28T00:00:00","2018-08-29T00:00:00","2018-08-30T00:00:00","2018-08-31T00:00:00","2018-09-01T00:00:00","2018-09-02T00:00:00","2018-09-03T00:00:00","2018-09-04T00:00:00"],"y":[0,1,0,18,13,9,29,23,1,2,23,31,32,20,19,1,0,24,14],"mode":"lines","fill":"tozeroy","name":" ","line":{"width":{},"color":"blue","shape":"spline","smoothing":100,"dash":"dash"},"marker":{"color":"blue"},"xaxis":"x","yaxis":"y"},{"type":"bar","x":["2018-08-17T00:00:00","2018-08-18T00:00:00","2018-08-19T00:00:00","2018-08-20T00:00:00","2018-08-21T00:00:00","2018-08-22T00:00:00","2018-08-23T00:00:00","2018-08-24T00:00:00","2018-08-25T00:00:00","2018-08-26T00:00:00","2018-08-27T00:00:00","2018-08-28T00:00:00","2018-08-29T00:00:00","2018-08-30T00:00:00","2018-08-31T00:00:00","2018-09-01T00:00:00","2018-09-02T00:00:00","2018-09-03T00:00:00","2018-09-04T00:00:00"],"y":[5,1,0,1,4,6,4,10,0,0,4,6,4,0,3,0,0,5,0],"marker":{"color":"rgb(246, 126, 0)"},"name":"BeerConsumption","xaxis":"x2","yaxis":"y2"},{"type":"scatter","x":["2018-08-17T00:00:00","2018-08-18T00:00:00","2018-08-19T00:00:00","2018-08-20T00:00:00","2018-08-21T00:00:00","2018-08-22T00:00:00","2018-08-23T00:00:00","2018-08-24T00:00:00","2018-08-25T00:00:00","2018-08-26T00:00:00","2018-08-27T00:00:00","2018-08-28T00:00:00","2018-08-29T00:00:00","2018-08-30T00:00:00","2018-08-31T00:00:00","2018-09-01T00:00:00","2018-09-02T00:00:00","2018-09-03T00:00:00","2018-09-04T00:00:00"],"y":[5,1,0,1,4,6,4,10,0,0,4,6,4,0,3,0,0,5,0],"mode":"lines","fill":"tozeroy","name":" ","line":{"width":{},"color":"orange","shape":"spline","smoothing":100,"dash":"dash"},"marker":{"color":"orange"},"xaxis":"x2","yaxis":"y2"},{"type":"bar","x":["2018-08-17T00:00:00","2018-08-18T00:00:00","2018-08-19T00:00:00","2018-08-20T00:00:00","2018-08-21T00:00:00","2018-08-22T00:00:00","2018-08-23T00:00:00","2018-08-24T00:00:00","2018-08-25T00:00:00","2018-08-26T00:00:00","2018-08-27T00:00:00","2018-08-28T00:00:00","2018-08-29T00:00:00","2018-08-30T00:00:00","2018-08-31T00:00:00","2018-09-01T00:00:00","2018-09-02T00:00:00","2018-09-03T00:00:00","2018-09-04T00:00:00"],"y":[0,0,0,3,2,5,6,3,1,0,0,7,2,0,2,1,0,0,0],"marker":{"color":"rgb(65, 160, 33)"},"name":"BeverageConsumption","xaxis":"x3","yaxis":"y3"},{"type":"scatter","x":["2018-08-17T00:00:00","2018-08-18T00:00:00","2018-08-19T00:00:00","2018-08-20T00:00:00","2018-08-21T00:00:00","2018-08-22T00:00:00","2018-08-23T00:00:00","2018-08-24T00:00:00","2018-08-25T00:00:00","2018-08-26T00:00:00","2018-08-27T00:00:00","2018-08-28T00:00:00","2018-08-29T00:00:00","2018-08-30T00:00:00","2018-08-31T00:00:00","2018-09-01T00:00:00","2018-09-02T00:00:00","2018-09-03T00:00:00","2018-09-04T00:00:00"],"y":[0,0,0,3,2,5,6,3,1,0,0,7,2,0,2,1,0,0,0],"mode":"lines","fill":"tozeroy","name":" ","line":{"width":{},"color":"green","shape":"spline","smoothing":100,"dash":"dash"},"marker":{"color":"green"},"xaxis":"x3","yaxis":"y3"}];
  var layout = {"yaxis":{"tickmode":"auto","ticks":"inside","mirror":"all","showline":true,"showgrid":false,"titlefont":{"family":"Arial","size":15.0},"tickfont":{"family":"Arial","size":15.0},"title":"Consumption [cups]","range":[0.0,33.0],"anchor":"x","domain":[0.71666666666666667,1.0]},"xaxis":{"tickmode":"auto","ticks":"inside","mirror":"all","showline":true,"showgrid":false,"zeroline":false,"titlefont":{"family":"Arial","size":15.0},"tickfont":{"family":"Arial","size":15.0},"anchor":"y","domain":[0.0,0.95]},"yaxis2":{"tickmode":"auto","ticks":"inside","mirror":"all","showline":true,"showgrid":false,"titlefont":{"family":"Arial","size":15.0},"tickfont":{"family":"Arial","size":15.0},"title":"Consumption [huelsen]","range":[0.0,33.0],"anchor":"x2","domain":[0.38333333333333341,0.66666666666666674]},"xaxis2":{"tickmode":"auto","ticks":"inside","mirror":"all","showline":true,"showgrid":false,"zeroline":false,"titlefont":{"family":"Arial","size":15.0},"tickfont":{"family":"Arial","size":15.0},"anchor":"y2","domain":[0.0,0.95]},"yaxis3":{"tickmode":"auto","ticks":"inside","mirror":"all","showline":true,"showgrid":false,"titlefont":{"family":"Arial","size":15.0},"tickfont":{"family":"Arial","size":15.0},"title":"Consumption [bottles]","range":[0.0,33.0],"anchor":"x3","domain":[0.050000000000000044,0.33333333333333337]},"xaxis3":{"tickmode":"auto","ticks":"inside","mirror":"all","showline":true,"showgrid":false,"zeroline":false,"titlefont":{"family":"Arial","size":15.0},"tickfont":{"family":"Arial","size":15.0},"anchor":"y3","domain":[0.0,0.95]},"width":1000.0,"height":750.0};
  Plotly.newPlot('e075b67b-a726-4a55-a26c-4be921c46433', data, layout);
</script>  

### Fractions
The total consumption consists of the following fractions:

 * 260 coffees
 * 53 beers 
 * 32 other beverages.  
 
<div class="PlotlyChart" id="366cabba-b467-4f10-b2de-2c5992d6980c" style="width: 600px; height: 600px;"><!-- Plotly chart will be drawn inside this DIV --></div>        
<script>
  var data = [{"type":"pie","values":[260,32,53],"labels":["Coffee","Beverages","Beer"],"marker":{},"text":["Coffee","Beverages","Beer"]}];
  var layout = {};
  Plotly.newPlot('366cabba-b467-4f10-b2de-2c5992d6980c', data, layout);
</script>  

## Consumption stats

### Distribution by team
Coffee consumption is by far the highest in the ITCrowd team. This may be due to the widely accepted rule that liquid coffee can be directly converted to code by our bodies using a pathway called "I will stay until this code works". Or maybe some caffeine addiction problems. Your call.

The team with the next lower coffee consumption is the Mibis team. This is not surprising since ITCrowd and Mibis used the coffee machine together way before the move to the new building.

The low coffee consumption of the other teams could be explayined by them either primarily using their own coffee machines or not all team members knowing about the system yet.
However, the beer consumption of some of these teams points more to the former than the latter.

ITCrowd is also the top dog of other beverage consumption (did I mention that I like afri cola?)  

<div class="PlotlyChart" id="8b2201a7-8f55-4bf6-8fbf-5956967303bc" style="width: 1000px; height: 750px;"><!-- Plotly chart will be drawn inside this DIV --></div>        
<script>
  var data = [{"type":"bar","x":["Fungis","ITCrowd","Mibis","hotOrNot","Ribos"],"y":[4,169,71,14,6],"marker":{},"name":"CoffeeConsumption","showlegend":true,"textposition":"top right","xaxis":"x","yaxis":"y"},{"type":"bar","x":["Fungis","ITCrowd","Mibis","hotOrNot","Ribos"],"y":[6,11,4,17,15],"marker":{},"name":"BeerConsumption","showlegend":true,"textposition":"top right","xaxis":"x2","yaxis":"y2"},{"type":"bar","x":["Fungis","ITCrowd","Mibis","hotOrNot","Ribos"],"y":[2,20,1,5,4],"marker":{},"name":"BeverageConsumption","xaxis":"x3","yaxis":"y3"}];
  var layout = {"yaxis":{"tickmode":"auto","ticks":"inside","mirror":"all","showline":true,"showgrid":false,"titlefont":{"family":"Arial","size":15.0},"tickfont":{"family":"Arial","size":15.0},"title":"Consumption [cups]","anchor":"x","domain":[0.71666666666666667,1.0]},"xaxis":{"tickmode":"auto","ticks":"inside","mirror":"all","showline":true,"showgrid":false,"zeroline":false,"titlefont":{"family":"Arial","size":15.0},"tickfont":{"family":"Arial","size":15.0},"anchor":"y","domain":[0.0,0.95]},"yaxis2":{"tickmode":"auto","ticks":"inside","mirror":"all","showline":true,"showgrid":false,"titlefont":{"family":"Arial","size":15.0},"tickfont":{"family":"Arial","size":15.0},"title":"Consumption [huelsen]","anchor":"x2","domain":[0.38333333333333341,0.66666666666666674]},"xaxis2":{"tickmode":"auto","ticks":"inside","mirror":"all","showline":true,"showgrid":false,"zeroline":false,"titlefont":{"family":"Arial","size":15.0},"tickfont":{"family":"Arial","size":15.0},"anchor":"y2","domain":[0.0,0.95]},"yaxis3":{"tickmode":"auto","ticks":"inside","mirror":"all","showline":true,"showgrid":false,"titlefont":{"family":"Arial","size":15.0},"tickfont":{"family":"Arial","size":15.0},"title":"Consumption [bottles]","anchor":"x3","domain":[0.050000000000000044,0.33333333333333337]},"xaxis3":{"tickmode":"auto","ticks":"inside","mirror":"all","showline":true,"showgrid":false,"zeroline":false,"titlefont":{"family":"Arial","size":15.0},"tickfont":{"family":"Arial","size":15.0},"anchor":"y3","domain":[0.0,0.95]},"width":1000.0,"height":750.0};
  Plotly.newPlot('8b2201a7-8f55-4bf6-8fbf-5956967303bc', data, layout);
</script>

### Population distribution

There seems to be only two types of coffee drinkers: Those that drink many cups, and those that drink a low amount of cups. A middle ground seems to be missing, but this could be due to the for us invisible amount of coffe from other machines that we can't register.
This seems not to be the case for the other types of drinks, where the decay from high to low consumption looks much more linear. Further clustering analysis could be used to further test this observation.  

<div class="PlotlyChart" id="383d0f9c-c6a0-45b5-b52b-2e9901f13a55" style="width: 1000px; height: 750px;"><!-- Plotly chart will be drawn inside this DIV --></div>        
<script>
  var data = [{"type":"bar","x":[0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25],"y":[32,30,27,25,25,23,21,9,9,7,7,7,6,6,5,4,4,3,3,2,2,2,2,1,1,1],"marker":{},"name":"CoffeeConsumption","xaxis":"x","yaxis":"y"},{"type":"bar","x":[0,1,2,3,4,5,6,7,8,9,10,11,12],"y":[8,7,7,7,5,4,4,3,3,2,1,1,1],"marker":{},"name":"BeerConsumption","xaxis":"x2","yaxis":"y2"},{"type":"bar","x":[0,1,2,3,4,5,6,7,8,9,10,11,12,13],"y":[5,5,3,3,3,3,2,2,1,1,1,1,1,1],"marker":{},"name":"BeverageConsumption","xaxis":"x3","yaxis":"y3"}];
  var layout = {"yaxis":{"tickmode":"auto","ticks":"inside","mirror":"all","showline":true,"showgrid":false,"titlefont":{"family":"Arial","size":15.0},"tickfont":{"family":"Arial","size":15.0},"title":"Consumption [cups]","anchor":"x","domain":[0.71666666666666667,1.0]},"xaxis":{"tickmode":"auto","ticks":"inside","mirror":"all","showline":true,"showgrid":false,"zeroline":false,"titlefont":{"family":"Arial","size":15.0},"tickfont":{"family":"Arial","size":15.0},"anchor":"y","domain":[0.0,0.95]},"yaxis2":{"tickmode":"auto","ticks":"inside","mirror":"all","showline":true,"showgrid":false,"titlefont":{"family":"Arial","size":15.0},"tickfont":{"family":"Arial","size":15.0},"title":"Consumption [huelsen]","anchor":"x2","domain":[0.38333333333333341,0.66666666666666674]},"xaxis2":{"tickmode":"auto","ticks":"inside","mirror":"all","showline":true,"showgrid":false,"zeroline":false,"titlefont":{"family":"Arial","size":15.0},"tickfont":{"family":"Arial","size":15.0},"anchor":"y2","domain":[0.0,0.95]},"yaxis3":{"tickmode":"auto","ticks":"inside","mirror":"all","showline":true,"showgrid":false,"titlefont":{"family":"Arial","size":15.0},"tickfont":{"family":"Arial","size":15.0},"title":"Consumption [bottles]","anchor":"x3","domain":[0.050000000000000044,0.33333333333333337]},"xaxis3":{"tickmode":"auto","ticks":"inside","mirror":"all","showline":true,"showgrid":false,"zeroline":false,"titlefont":{"family":"Arial","size":15.0},"tickfont":{"family":"Arial","size":15.0},"anchor":"y3","domain":[0.0,0.95]},"width":1000.0,"height":750.0};
  Plotly.newPlot('383d0f9c-c6a0-45b5-b52b-2e9901f13a55', data, layout);
</script>

## Distance stats

For this analysis, Venny and I chose the paths that we thought are most likely taken to walk to the coffee machine. If you feel like they are not adequate for your team, feel free to correct us.

<center><img src="../img/Distances.png" width="850px"></center>

The distances for a one way walk to the coffee machines for the teams then are:

 * Fungis   : 25.2m
 * hotOrNot : 29.5m
 * Mibis    : 36.5m
 * Ribos    : 38.5m
 * ITCrowd  : 47m

Taking into account that most of the time, one also has to walk back after/to/while consuming the coffee, this distance is doubled for every walk.
As the team with the highest distance to the coffee machine is also the one with the highest coffee consumption, the ITCrowd team finishes at a total of almost 16(!) walked kilometers, only to get coffee.
As the distances and coffee consumption of the other teams are lower, the walked kilometers decrease drastically.  

<div class="PlotlyChart" id="f1808472-82db-4f1e-b4ff-751fbea243f3" style="width: 1000px; height: 750px;"><!-- Plotly chart will be drawn inside this DIV --></div>        
<script>
  var data = [{"type":"bar","x":["Fungis","ITCrowd","Mibis","hotOrNot","Ribos"],"y":[201.6,15886.0,5183.0,826.0,462.0],"marker":{},"name":"total distance traveled","xaxis":"x","yaxis":"y"},{"type":"bar","x":["Fungis","ITCrowd","Mibis","hotOrNot","Ribos"],"y":[201.6,1985.75,471.18181818181819,206.5,231.0],"marker":{},"name":"mean distance traveled","error_y":{"array":["NaN",981.3084195530547,489.00589325320368,140.44809242800938,217.78888860545663]},"xaxis":"x2","yaxis":"y2"}];
  var layout = {"yaxis":{"tickmode":"auto","ticks":"inside","mirror":"all","showline":true,"showgrid":false,"titlefont":{"family":"Arial","size":15.0},"tickfont":{"family":"Arial","size":15.0},"title":"Total distance traveled [m]","anchor":"x","domain":[0.55,1.0]},"xaxis":{"tickmode":"auto","ticks":"inside","mirror":"all","showline":true,"showgrid":false,"zeroline":false,"titlefont":{"family":"Arial","size":15.0},"tickfont":{"family":"Arial","size":15.0},"anchor":"y","domain":[0.0,0.95]},"yaxis2":{"tickmode":"auto","ticks":"inside","mirror":"all","showline":true,"showgrid":false,"titlefont":{"family":"Arial","size":15.0},"tickfont":{"family":"Arial","size":15.0},"title":"mean distance traveled [m/person]","anchor":"x2","domain":[0.050000000000000044,0.5]},"xaxis2":{"tickmode":"auto","ticks":"inside","mirror":"all","showline":true,"showgrid":false,"zeroline":false,"titlefont":{"family":"Arial","size":15.0},"tickfont":{"family":"Arial","size":15.0},"anchor":"y2","domain":[0.0,0.95]},"width":1000.0,"height":750.0};
  Plotly.newPlot('f1808472-82db-4f1e-b4ff-751fbea243f3', data, layout);
</script>

## Final remarks
The main conclusion that can be drawn from this analysis is that the coffee machine is mainly used by the people which already used it before the move (ITCrowd and Mibis).
The other teams mainly use the ticking system for either alcoholic or non alcoholic beverages, and are either no big coffee drinkers or still use their own coffee machines. 
However, if you think this effect is due to problems using the new system, feel free to send me an email with your questions about the ticking system.

If you have ideas of other ways to look at this data or are interested in the datasets yourself, you are also welcome to write me an email or discuss it with me directly.

So far this was fun. I will use these kinds of reports in the future to explore more ways of analyzing the datasets we get by the ticking system and will include them in future reports.

So long and happy ticking,

Kevin

*)


