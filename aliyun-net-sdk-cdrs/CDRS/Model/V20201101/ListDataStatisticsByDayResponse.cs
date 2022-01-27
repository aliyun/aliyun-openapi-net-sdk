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
	public class ListDataStatisticsByDayResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private long? pageNumber;

		private long? pageSize;

		private long? totalCount;

		private List<ListDataStatisticsByDay_Datas> data;

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

		public List<ListDataStatisticsByDay_Datas> Data
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

		public class ListDataStatisticsByDay_Datas
		{

			private string date;

			private string corpId;

			private int? faceNumber;

			private int? bodyNumber;

			private int? motorNumber;

			private int? nonMotorNumber;

			private int? totalNumber;

			public string Date
			{
				get
				{
					return date;
				}
				set	
				{
					date = value;
				}
			}

			public string CorpId
			{
				get
				{
					return corpId;
				}
				set	
				{
					corpId = value;
				}
			}

			public int? FaceNumber
			{
				get
				{
					return faceNumber;
				}
				set	
				{
					faceNumber = value;
				}
			}

			public int? BodyNumber
			{
				get
				{
					return bodyNumber;
				}
				set	
				{
					bodyNumber = value;
				}
			}

			public int? MotorNumber
			{
				get
				{
					return motorNumber;
				}
				set	
				{
					motorNumber = value;
				}
			}

			public int? NonMotorNumber
			{
				get
				{
					return nonMotorNumber;
				}
				set	
				{
					nonMotorNumber = value;
				}
			}

			public int? TotalNumber
			{
				get
				{
					return totalNumber;
				}
				set	
				{
					totalNumber = value;
				}
			}
		}
	}
}
