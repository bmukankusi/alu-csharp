﻿using System;

/// <summary>
/// player class
/// </summary>
public class Player {

   
    private string name = "Player";

    private float maxHp = 100f;


    private float hp;

   /// <summary>
   /// calculatehealth delegate
   /// </summary>
   /// <param name="amount"></param>
    delegate void CalculateHealth(float amount);

    /// <summary>
    /// player method
    /// </summary>
    /// <param name="name"></param>
    /// <param name="maxHp"></param>
    public Player(string name = "Player", float maxHp = 100f){

        if(maxHp <= 0){
            this.maxHp = 100f;
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }else{
               this.maxHp = maxHp;
        }

        this.name = name;
        hp = this.maxHp;
    }

 


/// <summary>
/// take damage method
/// </summary>
/// <param name="damage"></param>
    public void TakeDamage(float damage){
        
        if(damage < 0){
            Console.WriteLine($"{name} takes 0 damage!");
        }else{
            hp -= damage;
            Console.WriteLine($"{name} takes {damage} damage!");
        }
        ValidateHP(hp);
    }

    /// <summary>
    /// heldamage method
    /// </summary>
    /// <param name="heal"></param>
    public void HealDamage(float heal){
        
        if(heal < 0){
            Console.WriteLine($"{name} heals 0 HP!");
        }else{
            hp += heal;
            Console.WriteLine($"{name} heals {heal} HP!");
        }
        ValidateHP(hp);
    }

/// <summary>
/// validatehp method
/// </summary>
/// <param name="newHp"></param>
    public void ValidateHP(float newHp){
        if(newHp < 0 ){
            hp  = 0;
        }else if(newHp > maxHp){
            hp = maxHp;
        }else{
            hp = newHp;
        }
    }

    /// <summary>
    /// printhealth mthod
    /// </summary>
    public void PrintHealth(){
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }

}