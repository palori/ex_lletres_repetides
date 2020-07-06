// JavaScript source code
 
fase1();
fase2();
fase3();
fase4();


function title(title)
{
    console.log("\n\n---\n"+title+":\n");
}

function fase1()
{
    title("fase1");
    var name = ['P','a','u'];
    console.log("Option 1:");
    for (var i = 0; i < name.length; i++)
    {
        //console.log("nom["+i+"] = "+name[i]);
        console.log(`nom[${i}] = ${name[i]}`);
    }
    
    console.log("\nOption 2:\nname = {");
    for (n in name)
    {
        //console.log("  '"+n+"'");
        console.log(`  '${name[n]}'`);
    }
    console.log("  }");
}

function fase2()
{
    title("fase2");
    var name = new Array();
    name.push('P');
    name.push('a');
    name.push('1');
    name.push('!');
    
    for (n in name)
    {
        // SOURCE: http://www.asciitable.com/
        var name_ascii = name[n].charCodeAt(0);
        // lletres majúscules i minúscules (sense accents, dièresis...)
        if((name_ascii >= 65 && name_ascii<=90) || (name_ascii >= 97 && name_ascii<=122))
        {
            // vocals
            if(name[n]=='A'||name[n]=='E'||name[n]=='I'||name[n]=='O'||name[n]=='U'||name[n]=='a'||name[n]=='e'||name[n]=='i'||name[n]=='o'||name[n]=='u')
            {
                console.log("VOCAL");
            }
            // consonants
            else
            {
                console.log("CONSONANT");
            }
        }
        // números
        else if(name_ascii >= 48 && name_ascii<=57)
        {
            console.log("Els noms de persones no contenen numeros!");
        }
        else
        {
            console.log("Aquest caracter no el reconeixo... :s");
        }
    }
}

function fase3()
{
    title("fase3");
    var name = new Array();
    name.push('P');
    name.push('a');
    name.push('1');
    name.push('!');
    name.push('I');
    name.push('m');
    name.push('m');
    name.push('a');

    var characters = {};
    for (var n in name)
    {
        if (characters[name[n]] == undefined)
        {
            characters[name[n]] = 1;
            
        }
        else
        {
            characters[name[n]] = characters[name[n]] + 1;
        }
    }

    // testing the algorithm (should be done as unit testing)
    /*var keys = characters.Keys;
    for (var k in keys)
    {
        console.log(`${keys[k]} = ${characters[keys[k]]}`);
    }*/
    for (var ch in characters)
    {
        console.log(`'${ch}' = ${characters[ch]}`);
    }
}

function fase4()
{
    title("fase4");
    var name = ['P','a','u'];
    var surname = ['L','o','p','e','z'];

    name.push(' ');
    var fullname = name.concat(surname);

    console.log("full name:");
    for(fn in fullname)
    {
        console.log(` ${fullname[fn]}`);
    }
}

