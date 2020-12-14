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

namespace Aliyun.Acs.CDRS.Model.V20201101
{
	public class ListPersonDetailsResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private long? pageNumber;

		private long? pageSize;

		private long? totalCount;

		private List<ListPersonDetails_Datas> data;

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

		public long? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
			}
		}

		public long? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
			}
		}

		public long? TotalCount
		{
			get
			{
				return totalCount;
			}
			set	
			{
				totalCount = value;
			}
		}

		public List<ListPersonDetails_Datas> Data
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

		public class ListPersonDetails_Datas
		{

			private string personId;

			private string gender;

			private string age;

			private string profession;

			private string address;

			private string transportation;

			private string personType;

			private string hotSpotAddress;

			private string updateTime;

			private string preferredColor;

			private string faceSourceImage;

			private string faceTargetImage;

			private string bodySourceImage;

			private string bodyTargetImage;

			private string prefOutTime;

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

			public string Profession
			{
				get
				{
					return profession;
				}
				set	
				{
					profession = value;
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

			public string Transportation
			{
				get
				{
					return transportation;
				}
				set	
				{
					transportation = value;
				}
			}

			public string PersonType
			{
				get
				{
					return personType;
				}
				set	
				{
					personType = value;
				}
			}

			public string HotSpotAddress
			{
				get
				{
					return hotSpotAddress;
				}
				set	
				{
					hotSpotAddress = value;
				}
			}

			public string UpdateTime
			{
				get
				{
					return updateTime;
				}
				set	
				{
					updateTime = value;
				}
			}

			public string PreferredColor
			{
				get
				{
					return preferredColor;
				}
				set	
				{
					preferredColor = value;
				}
			}

			public string FaceSourceImage
			{
				get
				{
					return faceSourceImage;
				}
				set	
				{
					faceSourceImage = value;
				}
			}

			public string FaceTargetImage
			{
				get
				{
					return faceTargetImage;
				}
				set	
				{
					faceTargetImage = value;
				}
			}

			public string BodySourceImage
			{
				get
				{
					return bodySourceImage;
				}
				set	
				{
					bodySourceImage = value;
				}
			}

			public string BodyTargetImage
			{
				get
				{
					return bodyTargetImage;
				}
				set	
				{
					bodyTargetImage = value;
				}
			}

			public string PrefOutTime
			{
				get
				{
					return prefOutTime;
				}
				set	
				{
					prefOutTime = value;
				}
			}
		}
	}
}
