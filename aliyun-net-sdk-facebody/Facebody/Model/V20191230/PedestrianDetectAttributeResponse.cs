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
	public class PedestrianDetectAttributeResponse : AcsResponse
	{

		private string requestId;

		private PedestrianDetectAttribute_Data data;

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

		public PedestrianDetectAttribute_Data Data
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

		public class PedestrianDetectAttribute_Data
		{

			private int? personNumber;

			private List<PedestrianDetectAttribute_AttributesItem> attributes;

			private List<PedestrianDetectAttribute_BoxesItem> boxes;

			public int? PersonNumber
			{
				get
				{
					return personNumber;
				}
				set	
				{
					personNumber = value;
				}
			}

			public List<PedestrianDetectAttribute_AttributesItem> Attributes
			{
				get
				{
					return attributes;
				}
				set	
				{
					attributes = value;
				}
			}

			public List<PedestrianDetectAttribute_BoxesItem> Boxes
			{
				get
				{
					return boxes;
				}
				set	
				{
					boxes = value;
				}
			}

			public class PedestrianDetectAttribute_AttributesItem
			{

				private PedestrianDetectAttribute_Age age;

				private PedestrianDetectAttribute_Backpack backpack;

				private PedestrianDetectAttribute_Gender gender;

				private PedestrianDetectAttribute_Glasses glasses;

				private PedestrianDetectAttribute_Handbag handbag;

				private PedestrianDetectAttribute_Hat hat;

				private PedestrianDetectAttribute_LowerColor lowerColor;

				private PedestrianDetectAttribute_LowerWear lowerWear;

				private PedestrianDetectAttribute_Orient orient;

				private PedestrianDetectAttribute_ShoulderBag shoulderBag;

				private PedestrianDetectAttribute_UpperColor upperColor;

				private PedestrianDetectAttribute_UpperWear upperWear;

				public PedestrianDetectAttribute_Age Age
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

				public PedestrianDetectAttribute_Backpack Backpack
				{
					get
					{
						return backpack;
					}
					set	
					{
						backpack = value;
					}
				}

				public PedestrianDetectAttribute_Gender Gender
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

				public PedestrianDetectAttribute_Glasses Glasses
				{
					get
					{
						return glasses;
					}
					set	
					{
						glasses = value;
					}
				}

				public PedestrianDetectAttribute_Handbag Handbag
				{
					get
					{
						return handbag;
					}
					set	
					{
						handbag = value;
					}
				}

				public PedestrianDetectAttribute_Hat Hat
				{
					get
					{
						return hat;
					}
					set	
					{
						hat = value;
					}
				}

				public PedestrianDetectAttribute_LowerColor LowerColor
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

				public PedestrianDetectAttribute_LowerWear LowerWear
				{
					get
					{
						return lowerWear;
					}
					set	
					{
						lowerWear = value;
					}
				}

				public PedestrianDetectAttribute_Orient Orient
				{
					get
					{
						return orient;
					}
					set	
					{
						orient = value;
					}
				}

				public PedestrianDetectAttribute_ShoulderBag ShoulderBag
				{
					get
					{
						return shoulderBag;
					}
					set	
					{
						shoulderBag = value;
					}
				}

				public PedestrianDetectAttribute_UpperColor UpperColor
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

				public PedestrianDetectAttribute_UpperWear UpperWear
				{
					get
					{
						return upperWear;
					}
					set	
					{
						upperWear = value;
					}
				}

				public class PedestrianDetectAttribute_Age
				{

					private string name;

					private float? score;

					public string Name
					{
						get
						{
							return name;
						}
						set	
						{
							name = value;
						}
					}

					public float? Score
					{
						get
						{
							return score;
						}
						set	
						{
							score = value;
						}
					}
				}

				public class PedestrianDetectAttribute_Backpack
				{

					private string name;

					private float? score;

					public string Name
					{
						get
						{
							return name;
						}
						set	
						{
							name = value;
						}
					}

					public float? Score
					{
						get
						{
							return score;
						}
						set	
						{
							score = value;
						}
					}
				}

				public class PedestrianDetectAttribute_Gender
				{

					private string name;

					private float? score;

					public string Name
					{
						get
						{
							return name;
						}
						set	
						{
							name = value;
						}
					}

					public float? Score
					{
						get
						{
							return score;
						}
						set	
						{
							score = value;
						}
					}
				}

				public class PedestrianDetectAttribute_Glasses
				{

					private string name;

					private float? score;

					public string Name
					{
						get
						{
							return name;
						}
						set	
						{
							name = value;
						}
					}

					public float? Score
					{
						get
						{
							return score;
						}
						set	
						{
							score = value;
						}
					}
				}

				public class PedestrianDetectAttribute_Handbag
				{

					private string name;

					private float? score;

					public string Name
					{
						get
						{
							return name;
						}
						set	
						{
							name = value;
						}
					}

					public float? Score
					{
						get
						{
							return score;
						}
						set	
						{
							score = value;
						}
					}
				}

				public class PedestrianDetectAttribute_Hat
				{

					private string name;

					private float? score;

					public string Name
					{
						get
						{
							return name;
						}
						set	
						{
							name = value;
						}
					}

					public float? Score
					{
						get
						{
							return score;
						}
						set	
						{
							score = value;
						}
					}
				}

				public class PedestrianDetectAttribute_LowerColor
				{

					private string name;

					private float? score;

					public string Name
					{
						get
						{
							return name;
						}
						set	
						{
							name = value;
						}
					}

					public float? Score
					{
						get
						{
							return score;
						}
						set	
						{
							score = value;
						}
					}
				}

				public class PedestrianDetectAttribute_LowerWear
				{

					private string name;

					private float? score;

					public string Name
					{
						get
						{
							return name;
						}
						set	
						{
							name = value;
						}
					}

					public float? Score
					{
						get
						{
							return score;
						}
						set	
						{
							score = value;
						}
					}
				}

				public class PedestrianDetectAttribute_Orient
				{

					private string name;

					private float? score;

					public string Name
					{
						get
						{
							return name;
						}
						set	
						{
							name = value;
						}
					}

					public float? Score
					{
						get
						{
							return score;
						}
						set	
						{
							score = value;
						}
					}
				}

				public class PedestrianDetectAttribute_ShoulderBag
				{

					private string name;

					private float? score;

					public string Name
					{
						get
						{
							return name;
						}
						set	
						{
							name = value;
						}
					}

					public float? Score
					{
						get
						{
							return score;
						}
						set	
						{
							score = value;
						}
					}
				}

				public class PedestrianDetectAttribute_UpperColor
				{

					private string name;

					private float? score;

					public string Name
					{
						get
						{
							return name;
						}
						set	
						{
							name = value;
						}
					}

					public float? Score
					{
						get
						{
							return score;
						}
						set	
						{
							score = value;
						}
					}
				}

				public class PedestrianDetectAttribute_UpperWear
				{

					private string name;

					private float? score;

					public string Name
					{
						get
						{
							return name;
						}
						set	
						{
							name = value;
						}
					}

					public float? Score
					{
						get
						{
							return score;
						}
						set	
						{
							score = value;
						}
					}
				}
			}

			public class PedestrianDetectAttribute_BoxesItem
			{

				private float? score;

				private float? topLeftX;

				private float? topLeftY;

				private float? bottomRightX;

				private float? bottomRightY;

				public float? Score
				{
					get
					{
						return score;
					}
					set	
					{
						score = value;
					}
				}

				public float? TopLeftX
				{
					get
					{
						return topLeftX;
					}
					set	
					{
						topLeftX = value;
					}
				}

				public float? TopLeftY
				{
					get
					{
						return topLeftY;
					}
					set	
					{
						topLeftY = value;
					}
				}

				public float? BottomRightX
				{
					get
					{
						return bottomRightX;
					}
					set	
					{
						bottomRightX = value;
					}
				}

				public float? BottomRightY
				{
					get
					{
						return bottomRightY;
					}
					set	
					{
						bottomRightY = value;
					}
				}
			}
		}
	}
}
