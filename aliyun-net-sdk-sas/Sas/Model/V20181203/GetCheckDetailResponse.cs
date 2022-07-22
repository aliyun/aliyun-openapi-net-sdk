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
using Newtonsoft.Json;
using Aliyun.Acs.Core;

namespace Aliyun.Acs.Sas.Model.V20181203
{
	public class GetCheckDetailResponse : AcsResponse
	{

		private string requestId;

		private GetCheckDetail_Description description;

		private GetCheckDetail_Solution solution;

		private GetCheckDetail_AssistInfo assistInfo;

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

		public GetCheckDetail_Description Description
		{
			get
			{
				return description;
			}
			set	
			{
				description = value;
			}
		}

		public GetCheckDetail_Solution Solution
		{
			get
			{
				return solution;
			}
			set	
			{
				solution = value;
			}
		}

		public GetCheckDetail_AssistInfo AssistInfo
		{
			get
			{
				return assistInfo;
			}
			set	
			{
				assistInfo = value;
			}
		}

		public class GetCheckDetail_Description
		{

			private string type;

			private string _value;

			private string link;

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

			public string _Value
			{
				get
				{
					return _value;
				}
				set	
				{
					_value = value;
				}
			}

			public string Link
			{
				get
				{
					return link;
				}
				set	
				{
					link = value;
				}
			}
		}

		public class GetCheckDetail_Solution
		{

			private string type;

			private string _value;

			private string link;

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

			public string _Value
			{
				get
				{
					return _value;
				}
				set	
				{
					_value = value;
				}
			}

			public string Link
			{
				get
				{
					return link;
				}
				set	
				{
					link = value;
				}
			}
		}

		public class GetCheckDetail_AssistInfo
		{

			private string type;

			private string _value;

			private string link;

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

			public string _Value
			{
				get
				{
					return _value;
				}
				set	
				{
					_value = value;
				}
			}

			public string Link
			{
				get
				{
					return link;
				}
				set	
				{
					link = value;
				}
			}
		}
	}
}
