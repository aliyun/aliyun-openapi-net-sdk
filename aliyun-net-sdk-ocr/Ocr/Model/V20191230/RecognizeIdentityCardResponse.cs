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

			private RecognizeIdentityCard_BackResult backResult;

			private RecognizeIdentityCard_FrontResult frontResult;

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

			public class RecognizeIdentityCard_BackResult
			{

				private string endDate;

				private string issue;

				private string startDate;

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
			}

			public class RecognizeIdentityCard_FrontResult
			{

				private string birthDate;

				private string gender;

				private string address;

				private string nationality;

				private string name;

				private string iDNumber;

				private List<RecognizeIdentityCard_FaceRectVertice> faceRectVertices;

				private List<RecognizeIdentityCard_CardArea> cardAreas;

				private RecognizeIdentityCard_FaceRectangle faceRectangle;

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

				public class RecognizeIdentityCard_FaceRectVertice
				{

					private float? y;

					private float? x;

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
				}

				public class RecognizeIdentityCard_CardArea
				{

					private float? y;

					private float? x;

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
				}

				public class RecognizeIdentityCard_FaceRectangle
				{

					private float? angle;

					private RecognizeIdentityCard_Size size;

					private RecognizeIdentityCard_Center center;

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

					public class RecognizeIdentityCard_Size
					{

						private float? width;

						private float? height;

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
					}

					public class RecognizeIdentityCard_Center
					{

						private float? y;

						private float? x;

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
					}
				}
			}
		}
	}
}
