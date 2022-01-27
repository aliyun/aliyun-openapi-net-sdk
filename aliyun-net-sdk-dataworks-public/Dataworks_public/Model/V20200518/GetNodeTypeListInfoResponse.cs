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

namespace Aliyun.Acs.dataworks_public.Model.V20200518
{
	public class GetNodeTypeListInfoResponse : AcsResponse
	{

		private string requestId;

		private GetNodeTypeListInfo_NodeTypeInfoList nodeTypeInfoList;

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

		public GetNodeTypeListInfo_NodeTypeInfoList NodeTypeInfoList
		{
			get
			{
				return nodeTypeInfoList;
			}
			set	
			{
				nodeTypeInfoList = value;
			}
		}

		public class GetNodeTypeListInfo_NodeTypeInfoList
		{

			private int? pageNumber;

			private int? pageSize;

			private int? totalCount;

			private List<GetNodeTypeListInfo_NodeTypeInfoItem> nodeTypeInfo;

			public int? PageNumber
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

			public int? PageSize
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

			public int? TotalCount
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

			public List<GetNodeTypeListInfo_NodeTypeInfoItem> NodeTypeInfo
			{
				get
				{
					return nodeTypeInfo;
				}
				set	
				{
					nodeTypeInfo = value;
				}
			}

			public class GetNodeTypeListInfo_NodeTypeInfoItem
			{

				private int? nodeType;

				private string nodeTypeName;

				public int? NodeType
				{
					get
					{
						return nodeType;
					}
					set	
					{
						nodeType = value;
					}
				}

				public string NodeTypeName
				{
					get
					{
						return nodeTypeName;
					}
					set	
					{
						nodeTypeName = value;
					}
				}
			}
		}
	}
}
