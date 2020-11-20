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

namespace Aliyun.Acs.facebody.Model.V20191230
{
	public class ExtractPedestrianFeatureAttrResponse : AcsResponse
	{

		private string requestId;

		private ExtractPedestrianFeatureAttr_Data data;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public ExtractPedestrianFeatureAttr_Data Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class ExtractPedestrianFeatureAttr_Data
		{

			private string objType;

			private float? objTypeScore;

			private string feature;

			private float? qualityScore;

			private string upperColor;

			private float? upperColorScore;

			private string upperType;

			private float? upperTypeScore;

			private string lowerColor;

			private float? lowerColorScore;

			private string lowerType;

			private float? lowerTypeScore;

			private string gender;

			private float? genderScore;

			private string hair;

			private float? hairScore;

			private string age;

			private float? ageScore;

			public string ObjType
			{
				get
				{
					return objType;
				}
				set	
				{
					objType = value;
				}
			}

			public float? ObjTypeScore
			{
				get
				{
					return objTypeScore;
				}
				set	
				{
					objTypeScore = value;
				}
			}

			public string Feature
			{
				get
				{
					return feature;
				}
				set	
				{
					feature = value;
				}
			}

			public float? QualityScore
			{
				get
				{
					return qualityScore;
				}
				set	
				{
					qualityScore = value;
				}
			}

			public string UpperColor
			{
				get
				{
					return upperColor;
				}
				set	
				{
					upperColor = value;
				}
			}

			public float? UpperColorScore
			{
				get
				{
					return upperColorScore;
				}
				set	
				{
					upperColorScore = value;
				}
			}

			public string UpperType
			{
				get
				{
					return upperType;
				}
				set	
				{
					upperType = value;
				}
			}

			public float? UpperTypeScore
			{
				get
				{
					return upperTypeScore;
				}
				set	
				{
					upperTypeScore = value;
				}
			}

			public string LowerColor
			{
				get
				{
					return lowerColor;
				}
				set	
				{
					lowerColor = value;
				}
			}

			public float? LowerColorScore
			{
				get
				{
					return lowerColorScore;
				}
				set	
				{
					lowerColorScore = value;
				}
			}

			public string LowerType
			{
				get
				{
					return lowerType;
				}
				set	
				{
					lowerType = value;
				}
			}

			public float? LowerTypeScore
			{
				get
				{
					return lowerTypeScore;
				}
				set	
				{
					lowerTypeScore = value;
				}
			}

			public string Gender
			{
				get
				{
					return gender;
				}
				set	
				{
					gender = value;
				}
			}

			public float? GenderScore
			{
				get
				{
					return genderScore;
				}
				set	
				{
					genderScore = value;
				}
			}

			public string Hair
			{
				get
				{
					return hair;
				}
				set	
				{
					hair = value;
				}
			}

			public float? HairScore
			{
				get
				{
					return hairScore;
				}
				set	
				{
					hairScore = value;
				}
			}

			public string Age
			{
				get
				{
					return age;
				}
				set	
				{
					age = value;
				}
			}

			public float? AgeScore
			{
				get
				{
					return ageScore;
				}
				set	
				{
					ageScore = value;
				}
			}
		}
	}
}
