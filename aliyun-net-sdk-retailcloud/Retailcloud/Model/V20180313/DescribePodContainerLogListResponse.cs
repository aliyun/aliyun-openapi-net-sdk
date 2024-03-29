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

namespace Aliyun.Acs.retailcloud.Model.V20180313
{
	public class DescribePodContainerLogListResponse : AcsResponse
	{

		private int? code;

		private string errMsg;

		private string requestId;

		private bool? success;

		private DescribePodContainerLogList_Result result;

		public int? Code
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

		public string ErrMsg
		{
			get
			{
				return errMsg;
			}
			set	
			{
				errMsg = value;
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

		public DescribePodContainerLogList_Result Result
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

		public class DescribePodContainerLogList_Result
		{

			private List<DescribePodContainerLogList_PodContainerLog> containerLogList;

			public List<DescribePodContainerLogList_PodContainerLog> ContainerLogList
			{
				get
				{
					return containerLogList;
				}
				set	
				{
					containerLogList = value;
				}
			}

			public class DescribePodContainerLogList_PodContainerLog
			{

				private string containerName;

				private string content;

				private string podName;

				public string ContainerName
				{
					get
					{
						return containerName;
					}
					set	
					{
						containerName = value;
					}
				}

				public string Content
				{
					get
					{
						return content;
					}
					set	
					{
						content = value;
					}
				}

				public string PodName
				{
					get
					{
						return podName;
					}
					set	
					{
						podName = value;
					}
				}
			}
		}
	}
}
