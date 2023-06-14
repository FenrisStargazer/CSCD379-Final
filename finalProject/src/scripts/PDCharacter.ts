export class PDCharacter {
    playerUN: string = ''
    characterId: number = 0
    characterData: CharacterData = new CharacterData()
    gloryInfo: Score = new Score()
    traits: PersonalityTraits = new PersonalityTraits()
    passions: Passions = new Passions()
    carriedEquipment: Equipment = new Equipment()
    statistics: Stats = new Stats()
    skillset: Skills = new Skills()
    combatSkillset: CombatSkills = new CombatSkills()
    magicInfo: Magic = new Magic()
    companion: Servant = new Servant()
    bestHorse: Horse = new Horse()
    extraHorse: Horse = new Horse()
    familyInfo: ExtraInfo = new ExtraInfo()
}


export class Trait{
    title: string = ''
    value: number = 0
    check: boolean = false
    isRel: boolean = false
    notes: string = ''
    
    constructor(title: string){
        this.title = title
    }
}
export class CharacterData{
    name: string = ''
    culture: string = ''
    religion: string = ''
    fatherName: string = ''
    fatherClass: string = ''
    childNumber: number = 0
    currentClass: string = ''
    age: number = 0
    yearBorn: number = 0
}
export class Score{
    totalGlory: number = 0
    gameGlory: number = 0
    joustWin: number = 0
    joustLoss: number = 0
}
export class PersonalityTraits{
    chaste: Trait = new Trait("Chaste")
    lustful: Trait = new Trait("Lustful")
    energetic: Trait = new Trait("Energetic")
    lazy: Trait = new Trait("Lazy")
    forgiving: Trait = new Trait("Forgiving")
    vengeful: Trait = new Trait("Vengeful")
    generous: Trait = new Trait("Generous")
    selfish: Trait = new Trait("Selfish")
    honest: Trait = new Trait("Honest")
    deceitful: Trait = new Trait("Deceitful")
    just: Trait = new Trait("Just")
    arbitrary: Trait = new Trait("Arbitrary")
    merciful: Trait = new Trait("Merciful")
    cruel: Trait = new Trait("Cruel")
    modest: Trait = new Trait("Modest")
    proud: Trait = new Trait("Proud")
    pious: Trait = new Trait("Pious")
    wordly: Trait = new Trait("Wordly")
    prudent: Trait = new Trait("Prudent")
    reckless: Trait = new Trait("Reckless")
    temperate: Trait = new Trait("Temperate")
    indulgent: Trait = new Trait("Indulgent")
    trusting: Trait = new Trait("Trusting")
    suspicious: Trait = new Trait("Suspicious")
    valorous: Trait = new Trait("Valorous")
    cowardly: Trait = new Trait("Cowardly")
}
export class Passions{
    loveDeity: Trait = new Trait("Love (Deity)")
    loyaltyLord: Trait = new Trait("Loyalty (Lord)")
    loveFamily: Trait = new Trait("Love (Family)")
    honor: Trait = new Trait("Honor")
    hospitality: Trait = new Trait("Hospitality")
}
export class Equipment{
    armorType: string = ''
    armorValue: number = 0
    armorNotes: string = ''
    clothingType: string = ''
    clothingValue: number = 0
    clothingNotes: string = ''
    weapon1Type: string = ''
    weapon1Notes: string = ''
    weapon2Type: string = ''
    weapon2Notes: string = ''
    miscItems: string = ''
}
export class Stats{
    siz: number = 0
    dex: number = 0
    str: number = 0
    con: number = 0
    app: number = 0
    damage: number = 0
    healRate: number = 0
    movementRate: number = 0
    totalHP: number = 0
    unconscious: number = 0
    currentHP: number = 0
    wounds: string = ''
    chirurgery: boolean = false
    distinctFeatures: string = ''
    womansGift: string = ''
}
export class Skills{
    awareness: Trait = new Trait("Awareness")
    boating: Trait = new Trait("Boating")
    chirurgery: Trait = new Trait("Chirurgery")
    compose: Trait = new Trait("Compose")
    courtesy: Trait = new Trait("Courtesy")
    dancing: Trait = new Trait("Dancing")
    faeLore: Trait = new Trait("Faerie Lore")
    Falconry: Trait = new Trait("Falconry")
    firstAid: Trait = new Trait("First Aid")
    flirting: Trait = new Trait("Flirting")
    folkLore: Trait = new Trait("Folk Lore")
    gaming: Trait = new Trait("Gaming")
    heraldry: Trait = new Trait("Heraldry")
    hunting: Trait = new Trait("Hunting")
    industry: Trait = new Trait("Industry")
    intrigue: Trait = new Trait("Intrigue")
    orate: Trait = new Trait("Orate")
    play: Trait = new Trait("Play")
    read: Trait = new Trait("Read")
    recognize: Trait = new Trait("Recognize")
    religion: Trait = new Trait("Religion")
    romance: Trait = new Trait("Romance")
    singing: Trait = new Trait("Singing")
    stewardship: Trait = new Trait("Stewardship")
    swimming: Trait = new Trait("Swimming")
    tourney: Trait = new Trait("Tourney")
    writeIn1: Trait = new Trait(". . . . .")
    writeIn2: Trait = new Trait(". . . . .")
    writeIn3: Trait = new Trait(". . . . .")
    writeIn4: Trait = new Trait(". . . . .")
}
export class CombatSkills{
    battle: Trait = new Trait("Battle")
    horsemanship: Trait = new Trait("Horsemanship")
    dagger: Trait = new Trait("Dagger")
    sword: Trait = new Trait("Sword")
    lance: Trait = new Trait("Lance")
    axe: Trait = new Trait("Axe")
    spear: Trait = new Trait("Spear")
    greatSword: Trait = new Trait("Great Sword")
    craoiseach: Trait = new Trait("Craoiseach")
    sling: Trait = new Trait("Sling")
    writeIn1: Trait = new Trait(". . . . .")
    writeIn2: Trait = new Trait(". . . . .")
    writeIn3: Trait = new Trait(". . . . .")
    writeIn4: Trait = new Trait(". . . . .")
}
export class Magic{
    insight: number = 0
    magicLimit: number = 0
    lifeForce: number = 0
    magicDefense: number = 0
    celLore: Trait = new Trait("Celestial Lore")
    geoLore: Trait = new Trait("Geomantic Lore")
    sight: Trait = new Trait("Sight")
    talent1: Trait = new Trait(". . . . .")
    talent2: Trait = new Trait(". . . . .")
    talent3: Trait = new Trait(". . . . .")
    talent4: Trait = new Trait(". . . . .")
    talent5: Trait = new Trait(". . . . .")
    talent6: Trait = new Trait(". . . . .")
    talent7: Trait = new Trait(". . . . .")
    talent8: Trait = new Trait(". . . . .")
    talent9: Trait = new Trait(". . . . .")
    talent10: Trait = new Trait(". . . . .")
}
export class Servant{
    title: string = ''
    name: string = ''
    age: number = 0
    skill1: Trait = new Trait(". . . . .")
    skill2: Trait = new Trait(". . . . .")
    skill3: Trait = new Trait(". . . . .")
    skill4: Trait = new Trait(". . . . .")
    mount: Horse = new Horse()
}
export class Horse{
    type: string = ''
    name: string = ''
    combatTrained: boolean = false
    siz: number = 0
    dex: number = 0
    str: number = 0
    con: number = 0
    move: number = 0
    damage: number = 0
    healRate: number = 0
    hp: number = 0
    armor: number = 0
    majorWound: number = 0
    unconscious: number = 0
    knockdown: number = 0
}
export class ExtraInfo{
    yearWed: number = 0
    spouseName: string = ''
    status: string = ''
    will: string = ''
    children: string = ''
    familyCharacteristic: string = ''
    traitGlory: number = 0
    passionGlory: number = 0
    chivalryGlory: number = 0
    religionGlory: number = 0
    holdingGlory: number = 0
    totalGlory: number = 0
    history: string = ''
    yearBorn: number = 0
    yearEnnobled: number = 0
    yearSquired: number = 0
    yearLanded: number = 0
    yearKnighted: number = 0
    yearRoundTable: number = 0
    yearDeath: number = 0
    holdings: string = ''
    landGlory: number = 0
    libra: number = 0
    denarii: number = 0
    homeEquipment: string = ''
    oldKnights: number = 0
    midKnights: number = 0
    youngKnights: number = 0
    totalFamKnights: number = 0
    vassalKnights: number = 0
    lineageMen: number = 0
    levy: number = 0
}