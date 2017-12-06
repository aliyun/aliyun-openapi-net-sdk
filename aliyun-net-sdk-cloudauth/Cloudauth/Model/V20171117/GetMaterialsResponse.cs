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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.Cloudauth.Model.V20171117
{
	public class GetMaterialsResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string message;

		private GetMaterials_Data data;

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

		public string Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
			}
		}

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
			}
		}

		public GetMaterials_Data Data
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

		public class GetMaterials_Data
		{

			private string name;

			private string identificationNumber;

			private string idCardType;

			private string idCardExpiry;

			private string address;

			private string sex;

			private string idCardFrontPic;

			private string idCardBackPic;

			private string facePic;

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

			public string IdentificationNumber
			{
				get
				{
					return identificationNumber;
				}
				set	
				{
					identificationNumber = value;
				}
			}

			public string IdCardType
			{
				get
				{
					return idCardType;
				}
				set	
				{
					idCardType = value;
				}
			}

			public string IdCardExpiry
			{
				get
				{
					return idCardExpiry;
				}
				set	
				{
					idCardExpiry = value;
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

			public string IdCardFrontPic
			{
				get
				{
					return idCardFrontPic;
				}
				set	
				{
					idCardFrontPic = value;
				}
			}

			public string IdCardBackPic
			{
				get
				{
					return idCardBackPic;
				}
				set	
				{
					idCardBackPic = value;
				}
			}

			public string FacePic
			{
				get
				{
					return facePic;
				}
				set	
				{
					facePic = value;
				}
			}
		}
	}
}