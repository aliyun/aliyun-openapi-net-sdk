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

namespace Aliyun.Acs.Drds.Model.V20190123
{
	public class DescribeHotDbListResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string msg;

		private DescribeHotDbList_Data data;

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

		public string Msg
		{
			get
			{
				return msg;
			}
			set	
			{
				msg = value;
			}
		}

		public DescribeHotDbList_Data Data
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

		public class DescribeHotDbList_Data
		{

			private string randomCode;

			private List<DescribeHotDbList_InstanceDb> list;

			public string RandomCode
			{
				get
				{
					return randomCode;
				}
				set	
				{
					randomCode = value;
				}
			}

			public List<DescribeHotDbList_InstanceDb> List
			{
				get
				{
					return list;
				}
				set	
				{
					list = value;
				}
			}

			public class DescribeHotDbList_InstanceDb
			{

				private string instanceName;

				private List<string> hotDbList;

				public string InstanceName
				{
					get
					{
						return instanceName;
					}
					set	
					{
						instanceName = value;
					}
				}

				public List<string> HotDbList
				{
					get
					{
						return hotDbList;
					}
					set	
					{
						hotDbList = value;
					}
				}
			}
		}
	}
}
