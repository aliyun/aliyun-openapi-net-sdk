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

namespace Aliyun.Acs.companyreg.Model.V20201022
{
	public class GetInitFlowResponse : AcsResponse
	{

		private string flowStatus;

		private string requestId;

		private List<GetInitFlow_NodeListItem> nodeList;

		public string FlowStatus
		{
			get
			{
				return flowStatus;
			}
			set	
			{
				flowStatus = value;
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

		public List<GetInitFlow_NodeListItem> NodeList
		{
			get
			{
				return nodeList;
			}
			set	
			{
				nodeList = value;
			}
		}

		public class GetInitFlow_NodeListItem
		{

			private int? index;

			private string status;

			private string description;

			private string code;

			private string name;

			private string failReason;

			private int? id;

			public int? Index
			{
				get
				{
					return index;
				}
				set	
				{
					index = value;
				}
			}

			public string Status
			{
				get
				{
					return status;
				}
				set	
				{
					status = value;
				}
			}

			public string Description
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

			public string FailReason
			{
				get
				{
					return failReason;
				}
				set	
				{
					failReason = value;
				}
			}

			public int? Id
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
		}
	}
}
