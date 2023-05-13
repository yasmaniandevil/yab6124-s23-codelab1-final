using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy
{
 public int health;
 public int damage;
 public float speed;
 public string name;
 public string type;

 public virtual void Move()
 {
  Debug.Log("Move from Enemy Class");
  //enemyTransform.Translate(Vector2.right * speed * Time.deltaTime);
 }
 
 
 
 
 /*public virtual void Attack()
 {
  Debug.Log("Enemy Attack Called");
 }*/

 //protected abstract void Update();
}

/* public Enemy()
 {
  health = 1;
  damage = 2;
  speed = 5;
  name = "Insert Name";
  type = "Enemy";

 }
 public Enemy(int health, int damage, int speed, string name)
 {
  this.health = health;
  this.damage = damage;
  this.speed = speed;
  this.name = "Insert Name";
  type = "Enemy";
 }*/
 

