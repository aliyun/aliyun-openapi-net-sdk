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
	public class RecognizeAccountPageResponse : AcsResponse
	{

		private string requestId;

		private RecognizeAccountPage_Data data;

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

		public RecognizeAccountPage_Data Data
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

		public class RecognizeAccountPage_Data
		{

			private float? angle;

			private string name;

			private string gender;

			private string relation;

			private string birthPlace;

			private string nationality;

			private string nativePlace;

			private string birthDate;

			private string iDNumber;

			private List<RecognizeAccountPage_InvalidStampArea> invalidStampAreas;

			private List<RecognizeAccountPage_UndertakeStampArea> undertakeStampAreas;

			private List<RecognizeAccountPage_RegisterStampArea> registerStampAreas;

			private List<RecognizeAccountPage_OtherStampArea> otherStampAreas;

			private RecognizeAccountPage_TitleArea titleArea;

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

			public string Relation
			{
				get
				{
					return relation;
				}
				set	
				{
					relation = value;
				}
			}

			public string BirthPlace
			{
				get
				{
					return birthPlace;
				}
				set	
				{
					birthPlace = value;
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

			public string NativePlace
			{
				get
				{
					return nativePlace;
				}
				set	
				{
					nativePlace = value;
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

			public List<RecognizeAccountPage_InvalidStampArea> InvalidStampAreas
			{
				get
				{
					return invalidStampAreas;
				}
				set	
				{
					invalidStampAreas = value;
				}
			}

			public List<RecognizeAccountPage_UndertakeStampArea> UndertakeStampAreas
			{
				get
				{
					return undertakeStampAreas;
				}
				set	
				{
					undertakeStampAreas = value;
				}
			}

			public List<RecognizeAccountPage_RegisterStampArea> RegisterStampAreas
			{
				get
				{
					return registerStampAreas;
				}
				set	
				{
					registerStampAreas = value;
				}
			}

			public List<RecognizeAccountPage_OtherStampArea> OtherStampAreas
			{
				get
				{
					return otherStampAreas;
				}
				set	
				{
					otherStampAreas = value;
				}
			}

			public RecognizeAccountPage_TitleArea TitleArea
			{
				get
				{
					return titleArea;
				}
				set	
				{
					titleArea = value;
				}
			}

			public class RecognizeAccountPage_InvalidStampArea
			{

				private int? left;

				private int? top;

				private int? height;

				private int? width;

				public int? Left
				{
					get
					{
						return left;
					}
					set	
					{
						left = value;
					}
				}

				public int? Top
				{
					get
					{
						return top;
					}
					set	
					{
						top = value;
					}
				}

				public int? Height
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

				public int? Width
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

			public class RecognizeAccountPage_UndertakeStampArea
			{

				private int? left;

				private int? top;

				private int? height;

				private int? width;

				public int? Left
				{
					get
					{
						return left;
					}
					set	
					{
						left = value;
					}
				}

				public int? Top
				{
					get
					{
						return top;
					}
					set	
					{
						top = value;
					}
				}

				public int? Height
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

				public int? Width
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

			public class RecognizeAccountPage_RegisterStampArea
			{

				private int? left;

				private int? top;

				private int? height;

				private int? width;

				public int? Left
				{
					get
					{
						return left;
					}
					set	
					{
						left = value;
					}
				}

				public int? Top
				{
					get
					{
						return top;
					}
					set	
					{
						top = value;
					}
				}

				public int? Height
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

				public int? Width
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

			public class RecognizeAccountPage_OtherStampArea
			{

				private int? left;

				private int? top;

				private int? height;

				private int? width;

				public int? Left
				{
					get
					{
						return left;
					}
					set	
					{
						left = value;
					}
				}

				public int? Top
				{
					get
					{
						return top;
					}
					set	
					{
						top = value;
					}
				}

				public int? Height
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

				public int? Width
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

			public class RecognizeAccountPage_TitleArea
			{

				private int? left;

				private int? top;

				private int? height;

				private int? width;

				public int? Left
				{
					get
					{
						return left;
					}
					set	
					{
						left = value;
					}
				}

				public int? Top
				{
					get
					{
						return top;
					}
					set	
					{
						top = value;
					}
				}

				public int? Height
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

				public int? Width
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
}
