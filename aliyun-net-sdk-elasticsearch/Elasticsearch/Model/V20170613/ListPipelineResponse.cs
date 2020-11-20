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

namespace Aliyun.Acs.elasticsearch.Model.V20170613
{
	public class ListPipelineResponse : AcsResponse
	{

		private string requestId;

		private List<ListPipeline_ResultItem> result;

		private ListPipeline_Headers headers;

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

		public List<ListPipeline_ResultItem> Result
		{
			get
			{
				return result;
			}
			set	
			{
				result = value;
			}
		}

		public ListPipeline_Headers Headers
		{
			get
			{
				return headers;
			}
			set	
			{
				headers = value;
			}
		}

		public class ListPipeline_ResultItem
		{

			private string pipelineId;

			private string pipelineStatus;

			private string gmtCreatedTime;

			private string gmtUpdateTime;

			public string PipelineId
			{
				get
				{
					return pipelineId;
				}
				set	
				{
					pipelineId = value;
				}
			}

			public string PipelineStatus
			{
				get
				{
					return pipelineStatus;
				}
				set	
				{
					pipelineStatus = value;
				}
			}

			public string GmtCreatedTime
			{
				get
				{
					return gmtCreatedTime;
				}
				set	
				{
					gmtCreatedTime = value;
				}
			}

			public string GmtUpdateTime
			{
				get
				{
					return gmtUpdateTime;
				}
				set	
				{
					gmtUpdateTime = value;
				}
			}
		}

		public class ListPipeline_Headers
		{

			private int? xTotalCount;

			public int? XTotalCount
			{
				get
				{
					return xTotalCount;
				}
				set	
				{
					xTotalCount = value;
				}
			}
		}
	}
}
