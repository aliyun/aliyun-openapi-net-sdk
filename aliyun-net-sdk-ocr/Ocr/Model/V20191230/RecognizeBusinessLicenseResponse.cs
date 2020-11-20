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
	public class RecognizeBusinessLicenseResponse : AcsResponse
	{

		private string requestId;

		private RecognizeBusinessLicense_Data data;

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

		public RecognizeBusinessLicense_Data Data
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

		public class RecognizeBusinessLicense_Data
		{

			private float? angle;

			private string registerNumber;

			private string name;

			private string type;

			private string legalPerson;

			private string establishDate;

			private string validPeriod;

			private string address;

			private string capital;

			private string business;

			private RecognizeBusinessLicense_Emblem emblem;

			private RecognizeBusinessLicense_Title title;

			private RecognizeBusinessLicense_Stamp stamp;

			private RecognizeBusinessLicense_QRCode qRCode;

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

			public string RegisterNumber
			{
				get
				{
					return registerNumber;
				}
				set	
				{
					registerNumber = value;
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

			public string Type
			{
				get
				{
					return type;
				}
				set	
				{
					type = value;
				}
			}

			public string LegalPerson
			{
				get
				{
					return legalPerson;
				}
				set	
				{
					legalPerson = value;
				}
			}

			public string EstablishDate
			{
				get
				{
					return establishDate;
				}
				set	
				{
					establishDate = value;
				}
			}

			public string ValidPeriod
			{
				get
				{
					return validPeriod;
				}
				set	
				{
					validPeriod = value;
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

			public string Capital
			{
				get
				{
					return capital;
				}
				set	
				{
					capital = value;
				}
			}

			public string Business
			{
				get
				{
					return business;
				}
				set	
				{
					business = value;
				}
			}

			public RecognizeBusinessLicense_Emblem Emblem
			{
				get
				{
					return emblem;
				}
				set	
				{
					emblem = value;
				}
			}

			public RecognizeBusinessLicense_Title Title
			{
				get
				{
					return title;
				}
				set	
				{
					title = value;
				}
			}

			public RecognizeBusinessLicense_Stamp Stamp
			{
				get
				{
					return stamp;
				}
				set	
				{
					stamp = value;
				}
			}

			public RecognizeBusinessLicense_QRCode QRCode
			{
				get
				{
					return qRCode;
				}
				set	
				{
					qRCode = value;
				}
			}

			public class RecognizeBusinessLicense_Emblem
			{

				private int? top;

				private int? left;

				private int? height;

				private int? width;

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

			public class RecognizeBusinessLicense_Title
			{

				private int? top;

				private int? left;

				private int? height;

				private int? width;

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

			public class RecognizeBusinessLicense_Stamp
			{

				private int? top;

				private int? left;

				private int? height;

				private int? width;

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

			public class RecognizeBusinessLicense_QRCode
			{

				private int? top;

				private int? left;

				private int? height;

				private int? width;

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
