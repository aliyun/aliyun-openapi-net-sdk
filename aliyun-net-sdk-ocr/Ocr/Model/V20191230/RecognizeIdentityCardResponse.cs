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

namespace Aliyun.Acs.ocr.Model.V20191230
{
	public class RecognizeIdentityCardResponse : AcsResponse
	{

		private string requestId;

		private RecognizeIdentityCard_Data data;

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

		public RecognizeIdentityCard_Data Data
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

		public class RecognizeIdentityCard_Data
		{

			private RecognizeIdentityCard_FrontResult frontResult;

			private RecognizeIdentityCard_BackResult backResult;

			public RecognizeIdentityCard_FrontResult FrontResult
			{
				get
				{
					return frontResult;
				}
				set	
				{
					frontResult = value;
				}
			}

			public RecognizeIdentityCard_BackResult BackResult
			{
				get
				{
					return backResult;
				}
				set	
				{
					backResult = value;
				}
			}

			public class RecognizeIdentityCard_FrontResult
			{

				private string address;

				private string name;

				private string nationality;

				private string iDNumber;

				private string gender;

				private string birthDate;

				private List<RecognizeIdentityCard_CardArea> cardAreas;

				private List<RecognizeIdentityCard_FaceRectVertice> faceRectVertices;

				private RecognizeIdentityCard_FaceRectangle faceRectangle;

				public string Address
				{
					get
					{
						return address;
					}
					set	
					{
						address = value;
					}
				}

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

				public string Nationality
				{
					get
					{
						return nationality;
					}
					set	
					{
						nationality = value;
					}
				}

				public string IDNumber
				{
					get
					{
						return iDNumber;
					}
					set	
					{
						iDNumber = value;
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

				public string BirthDate
				{
					get
					{
						return birthDate;
					}
					set	
					{
						birthDate = value;
					}
				}

				public List<RecognizeIdentityCard_CardArea> CardAreas
				{
					get
					{
						return cardAreas;
					}
					set	
					{
						cardAreas = value;
					}
				}

				public List<RecognizeIdentityCard_FaceRectVertice> FaceRectVertices
				{
					get
					{
						return faceRectVertices;
					}
					set	
					{
						faceRectVertices = value;
					}
				}

				public RecognizeIdentityCard_FaceRectangle FaceRectangle
				{
					get
					{
						return faceRectangle;
					}
					set	
					{
						faceRectangle = value;
					}
				}

				public class RecognizeIdentityCard_CardArea
				{

					private float? x;

					private float? y;

					public float? X
					{
						get
						{
							return x;
						}
						set	
						{
							x = value;
						}
					}

					public float? Y
					{
						get
						{
							return y;
						}
						set	
						{
							y = value;
						}
					}
				}

				public class RecognizeIdentityCard_FaceRectVertice
				{

					private float? x;

					private float? y;

					public float? X
					{
						get
						{
							return x;
						}
						set	
						{
							x = value;
						}
					}

					public float? Y
					{
						get
						{
							return y;
						}
						set	
						{
							y = value;
						}
					}
				}

				public class RecognizeIdentityCard_FaceRectangle
				{

					private float? angle;

					private RecognizeIdentityCard_Center center;

					private RecognizeIdentityCard_Size size;

					public float? Angle
					{
						get
						{
							return angle;
						}
						set	
						{
							angle = value;
						}
					}

					public RecognizeIdentityCard_Center Center
					{
						get
						{
							return center;
						}
						set	
						{
							center = value;
						}
					}

					public RecognizeIdentityCard_Size Size
					{
						get
						{
							return size;
						}
						set	
						{
							size = value;
						}
					}

					public class RecognizeIdentityCard_Center
					{

						private float? x;

						private float? y;

						public float? X
						{
							get
							{
								return x;
							}
							set	
							{
								x = value;
							}
						}

						public float? Y
						{
							get
							{
								return y;
							}
							set	
							{
								y = value;
							}
						}
					}

					public class RecognizeIdentityCard_Size
					{

						private float? height;

						private float? width;

						public float? Height
						{
							get
							{
								return height;
							}
							set	
							{
								height = value;
							}
						}

						public float? Width
						{
							get
							{
								return width;
							}
							set	
							{
								width = value;
							}
						}
					}
				}
			}

			public class RecognizeIdentityCard_BackResult
			{

				private string startDate;

				private string endDate;

				private string issue;

				public string StartDate
				{
					get
					{
						return startDate;
					}
					set	
					{
						startDate = value;
					}
				}

				public string EndDate
				{
					get
					{
						return endDate;
					}
					set	
					{
						endDate = value;
					}
				}

				public string Issue
				{
					get
					{
						return issue;
					}
					set	
					{
						issue = value;
					}
				}
			}
		}
	}
}
