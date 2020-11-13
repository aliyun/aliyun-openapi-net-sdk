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
	public class RecognizeChinapassportResponse : AcsResponse
	{

		private string requestId;

		private RecognizeChinapassport_Data data;

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

		public RecognizeChinapassport_Data Data
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

		public class RecognizeChinapassport_Data
		{

			private string authority;

			private string birthDate;

			private string birthDay;

			private string birthPlace;

			private string birthPlaceRaw;

			private string country;

			private string expiryDate;

			private string expiryDay;

			private string issueDate;

			private string issuePlace;

			private string issuePlaceRaw;

			private string lineZero;

			private string lineOne;

			private string name;

			private string nameChinese;

			private string nameChineseRaw;

			private string passportNo;

			private string personId;

			private string sex;

			private string sourceCountry;

			private bool? success;

			private string type;

			public string Authority
			{
				get
				{
					return authority;
				}
				set	
				{
					authority = value;
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

			public string BirthDay
			{
				get
				{
					return birthDay;
				}
				set	
				{
					birthDay = value;
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

			public string BirthPlaceRaw
			{
				get
				{
					return birthPlaceRaw;
				}
				set	
				{
					birthPlaceRaw = value;
				}
			}

			public string Country
			{
				get
				{
					return country;
				}
				set	
				{
					country = value;
				}
			}

			public string ExpiryDate
			{
				get
				{
					return expiryDate;
				}
				set	
				{
					expiryDate = value;
				}
			}

			public string ExpiryDay
			{
				get
				{
					return expiryDay;
				}
				set	
				{
					expiryDay = value;
				}
			}

			public string IssueDate
			{
				get
				{
					return issueDate;
				}
				set	
				{
					issueDate = value;
				}
			}

			public string IssuePlace
			{
				get
				{
					return issuePlace;
				}
				set	
				{
					issuePlace = value;
				}
			}

			public string IssuePlaceRaw
			{
				get
				{
					return issuePlaceRaw;
				}
				set	
				{
					issuePlaceRaw = value;
				}
			}

			public string LineZero
			{
				get
				{
					return lineZero;
				}
				set	
				{
					lineZero = value;
				}
			}

			public string LineOne
			{
				get
				{
					return lineOne;
				}
				set	
				{
					lineOne = value;
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

			public string NameChinese
			{
				get
				{
					return nameChinese;
				}
				set	
				{
					nameChinese = value;
				}
			}

			public string NameChineseRaw
			{
				get
				{
					return nameChineseRaw;
				}
				set	
				{
					nameChineseRaw = value;
				}
			}

			public string PassportNo
			{
				get
				{
					return passportNo;
				}
				set	
				{
					passportNo = value;
				}
			}

			public string PersonId
			{
				get
				{
					return personId;
				}
				set	
				{
					personId = value;
				}
			}

			public string Sex
			{
				get
				{
					return sex;
				}
				set	
				{
					sex = value;
				}
			}

			public string SourceCountry
			{
				get
				{
					return sourceCountry;
				}
				set	
				{
					sourceCountry = value;
				}
			}

			public bool? Success
			{
				get
				{
					return success;
				}
				set	
				{
					success = value;
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
		}
	}
}
