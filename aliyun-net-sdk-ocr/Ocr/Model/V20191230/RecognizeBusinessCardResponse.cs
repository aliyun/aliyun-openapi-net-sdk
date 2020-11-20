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
	public class RecognizeBusinessCardResponse : AcsResponse
	{

		private string requestId;

		private RecognizeBusinessCard_Data data;

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

		public RecognizeBusinessCard_Data Data
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

		public class RecognizeBusinessCard_Data
		{

			private string name;

			private List<string> companies;

			private List<string> departments;

			private List<string> titles;

			private List<string> cellPhoneNumbers;

			private List<string> officePhoneNumbers;

			private List<string> addresses;

			private List<string> emails;

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

			public List<string> Companies
			{
				get
				{
					return companies;
				}
				set	
				{
					companies = value;
				}
			}

			public List<string> Departments
			{
				get
				{
					return departments;
				}
				set	
				{
					departments = value;
				}
			}

			public List<string> Titles
			{
				get
				{
					return titles;
				}
				set	
				{
					titles = value;
				}
			}

			public List<string> CellPhoneNumbers
			{
				get
				{
					return cellPhoneNumbers;
				}
				set	
				{
					cellPhoneNumbers = value;
				}
			}

			public List<string> OfficePhoneNumbers
			{
				get
				{
					return officePhoneNumbers;
				}
				set	
				{
					officePhoneNumbers = value;
				}
			}

			public List<string> Addresses
			{
				get
				{
					return addresses;
				}
				set	
				{
					addresses = value;
				}
			}

			public List<string> Emails
			{
				get
				{
					return emails;
				}
				set	
				{
					emails = value;
				}
			}
		}
	}
}
