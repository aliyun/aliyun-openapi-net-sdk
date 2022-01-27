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

namespace Aliyun.Acs.Dds.Model.V20151201
{
	public class DescribeActiveOperationTaskTypeResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeActiveOperationTaskType_Items> typeList;

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

		public List<DescribeActiveOperationTaskType_Items> TypeList
		{
			get
			{
				return typeList;
			}
			set	
			{
				typeList = value;
			}
		}

		public class DescribeActiveOperationTaskType_Items
		{

			private string taskType;

			private string taskTypeInfoEn;

			private string taskTypeInfoZh;

			private int? count;

			public string TaskType
			{
				get
				{
					return taskType;
				}
				set	
				{
					taskType = value;
				}
			}

			public string TaskTypeInfoEn
			{
				get
				{
					return taskTypeInfoEn;
				}
				set	
				{
					taskTypeInfoEn = value;
				}
			}

			public string TaskTypeInfoZh
			{
				get
				{
					return taskTypeInfoZh;
				}
				set	
				{
					taskTypeInfoZh = value;
				}
			}

			public int? Count
			{
				get
				{
					return count;
				}
				set	
				{
					count = value;
				}
			}
		}
	}
}
