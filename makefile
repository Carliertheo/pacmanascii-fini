all: testchampspublic testproprietepublic testsumnentiers

testchampspublic:
	@dotnet run $@

testproprietepublic:
	@dotnet run $@
#$@ + le nom de la cible.

testsumnentiers:
	@dotnet run $@

.PHONY: all testchampspublic

# @dotnet run (execute la cible avant commande dotnetrun dans le cmd)