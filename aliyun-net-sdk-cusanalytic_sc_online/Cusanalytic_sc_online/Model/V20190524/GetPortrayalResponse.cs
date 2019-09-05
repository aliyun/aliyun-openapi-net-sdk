/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System.Collections.Generic;

using Aliyun.Acs.Core;

namespace Aliyun.Acs.cusanalytic_sc_online.Model.V20190524
{
	public class GetPortrayalResponse : AcsResponse
	{

		private float? femalePercent;

		private long? mcount;

		private long? mcount1120;

		private long? newcount;

		private float? agecount3140Percent;

		private float? agecount4150Percent;

		private float? agecount010Percent;

		private long? fcount5160;

		private long? mcount010;

		private long? mcountgt60;

		private float? agecount1120Percent;

		private long? fcountgt60;

		private long? fcount4150;

		private long? oldcount;

		private long? fcount3140;

		private long? fcount2130;

		private float? agecountgt60Percent;

		private long? fcount1120;

		private float? oldcountPercent;

		private long? mcount4150;

		private long? fcount;

		private float? newcountPercent;

		private long? mcount2130;

		private long? mcount3140;

		private float? agecount5160Percent;

		private float? agecount2130Percent;

		private long? fcount010;

		private long? mcount5160;

		private float? malePercent;

		public float? FemalePercent
		{
			get
			{
				return femalePercent;
			}
			set	
			{
				femalePercent = value;
			}
		}

		public long? Mcount
		{
			get
			{
				return mcount;
			}
			set	
			{
				mcount = value;
			}
		}

		public long? Mcount1120
		{
			get
			{
				return mcount1120;
			}
			set	
			{
				mcount1120 = value;
			}
		}

		public long? Newcount
		{
			get
			{
				return newcount;
			}
			set	
			{
				newcount = value;
			}
		}

		public float? Agecount3140Percent
		{
			get
			{
				return agecount3140Percent;
			}
			set	
			{
				agecount3140Percent = value;
			}
		}

		public float? Agecount4150Percent
		{
			get
			{
				return agecount4150Percent;
			}
			set	
			{
				agecount4150Percent = value;
			}
		}

		public float? Agecount010Percent
		{
			get
			{
				return agecount010Percent;
			}
			set	
			{
				agecount010Percent = value;
			}
		}

		public long? Fcount5160
		{
			get
			{
				return fcount5160;
			}
			set	
			{
				fcount5160 = value;
			}
		}

		public long? Mcount010
		{
			get
			{
				return mcount010;
			}
			set	
			{
				mcount010 = value;
			}
		}

		public long? Mcountgt60
		{
			get
			{
				return mcountgt60;
			}
			set	
			{
				mcountgt60 = value;
			}
		}

		public float? Agecount1120Percent
		{
			get
			{
				return agecount1120Percent;
			}
			set	
			{
				agecount1120Percent = value;
			}
		}

		public long? Fcountgt60
		{
			get
			{
				return fcountgt60;
			}
			set	
			{
				fcountgt60 = value;
			}
		}

		public long? Fcount4150
		{
			get
			{
				return fcount4150;
			}
			set	
			{
				fcount4150 = value;
			}
		}

		public long? Oldcount
		{
			get
			{
				return oldcount;
			}
			set	
			{
				oldcount = value;
			}
		}

		public long? Fcount3140
		{
			get
			{
				return fcount3140;
			}
			set	
			{
				fcount3140 = value;
			}
		}

		public long? Fcount2130
		{
			get
			{
				return fcount2130;
			}
			set	
			{
				fcount2130 = value;
			}
		}

		public float? Agecountgt60Percent
		{
			get
			{
				return agecountgt60Percent;
			}
			set	
			{
				agecountgt60Percent = value;
			}
		}

		public long? Fcount1120
		{
			get
			{
				return fcount1120;
			}
			set	
			{
				fcount1120 = value;
			}
		}

		public float? OldcountPercent
		{
			get
			{
				return oldcountPercent;
			}
			set	
			{
				oldcountPercent = value;
			}
		}

		public long? Mcount4150
		{
			get
			{
				return mcount4150;
			}
			set	
			{
				mcount4150 = value;
			}
		}

		public long? Fcount
		{
			get
			{
				return fcount;
			}
			set	
			{
				fcount = value;
			}
		}

		public float? NewcountPercent
		{
			get
			{
				return newcountPercent;
			}
			set	
			{
				newcountPercent = value;
			}
		}

		public long? Mcount2130
		{
			get
			{
				return mcount2130;
			}
			set	
			{
				mcount2130 = value;
			}
		}

		public long? Mcount3140
		{
			get
			{
				return mcount3140;
			}
			set	
			{
				mcount3140 = value;
			}
		}

		public float? Agecount5160Percent
		{
			get
			{
				return agecount5160Percent;
			}
			set	
			{
				agecount5160Percent = value;
			}
		}

		public float? Agecount2130Percent
		{
			get
			{
				return agecount2130Percent;
			}
			set	
			{
				agecount2130Percent = value;
			}
		}

		public long? Fcount010
		{
			get
			{
				return fcount010;
			}
			set	
			{
				fcount010 = value;
			}
		}

		public long? Mcount5160
		{
			get
			{
				return mcount5160;
			}
			set	
			{
				mcount5160 = value;
			}
		}

		public float? MalePercent
		{
			get
			{
				return malePercent;
			}
			set	
			{
				malePercent = value;
			}
		}
	}
}
