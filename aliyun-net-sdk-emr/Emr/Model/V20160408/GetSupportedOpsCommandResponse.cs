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

namespace Aliyun.Acs.Emr.Model.V20160408
{
	public class GetSupportedOpsCommandResponse : AcsResponse
	{

		private string requestId;

		private List<GetSupportedOpsCommand_OpsCommandCategory> list;

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

		public List<GetSupportedOpsCommand_OpsCommandCategory> List
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

		public class GetSupportedOpsCommand_OpsCommandCategory
		{

			private string category;

			private List<GetSupportedOpsCommand_OpsCommandInfo> commandList;

			public string Category
			{
				get
				{
					return category;
				}
				set	
				{
					category = value;
				}
			}

			public List<GetSupportedOpsCommand_OpsCommandInfo> CommandList
			{
				get
				{
					return commandList;
				}
				set	
				{
					commandList = value;
				}
			}

			public class GetSupportedOpsCommand_OpsCommandInfo
			{

				private string id;

				private string name;

				private string discription;

				private string targetType;

				private string _params;

				public string Id
				{
					get
					{
						return id;
					}
					set	
					{
						id = value;
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

				public string Discription
				{
					get
					{
						return discription;
					}
					set	
					{
						discription = value;
					}
				}

				public string TargetType
				{
					get
					{
						return targetType;
					}
					set	
					{
						targetType = value;
					}
				}

				public string _Params
				{
					get
					{
						return _params;
					}
					set	
					{
						_params = value;
					}
				}
			}
		}
	}
}
