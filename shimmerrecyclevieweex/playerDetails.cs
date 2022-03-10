using Android;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace shimmerrecyclevieweex
{
    class player
    {
        public player(int id, string name, string description)
        {
            PhotoId = id;
            Fname = name;
            Fdescription = description;

        }

        public int PhotoId { get; }
        public string Fname { get; }
        public string Fdescription { get; }
    }
    class playerDetails
    {

        static player[] frnd = {

            new player(Resource.Drawable.cr7,"ronaldo"," 804 goals"),
            new player(Resource.Drawable.Icon,"messi","756 goals  "),
          
            new player(Resource.Drawable.km7,"mbappe","186 goals"),
            new player(Resource.Drawable.ms11,"salah","156 goals"),
            new player(Resource.Drawable.ny10,"neymar","402 goals"),
            new player(Resource.Drawable.Zlatan,"zlatan","624 goals"),
            new player(Resource.Drawable.lewandowski,"lewandowski","620 goals"),
            new player(Resource.Drawable.kaka,"kaka","102 goals"),
           
          

            };

        private player[] mfrnd;

        Random random;

        public playerDetails()
        {
            mfrnd = frnd;
            random = new Random();
        }

        public int Numbplayer
        {

            get { return mfrnd.Length; }
        }

        public player this[int i]
        {
            get { return mfrnd[i]; }
        }

        public int RandomSwap()
        {
            player tempfrnd = mfrnd[0];

            int mrandom = random.Next(1, mfrnd.Length);

            mfrnd[0] = mfrnd[mrandom];
            mfrnd[mrandom] = tempfrnd;

            return mrandom;
        }

        public void Suffle()
        {
            for (int i = 0; i < mfrnd.Length; i++)
            {
                player tempfrnd = mfrnd[i];


                int mrandom = random.Next(1, mfrnd.Length);

                mfrnd[i] = mfrnd[mrandom];
                mfrnd[mrandom] = tempfrnd;
            }

        }
    }
}