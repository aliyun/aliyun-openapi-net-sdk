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

namespace Aliyun.Acs.aegis.Model.V20161111
{
	public class DescribeLogMetaResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private List<DescribeLogMeta_LogMeta> logMetaList;

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

		public List<DescribeLogMeta_LogMeta> LogMetaList
		{
			get
			{
				return logMetaList;
			}
			set	
			{
				logMetaList = value;
			}
		}

		public class DescribeLogMeta_LogMeta
		{

			private string project;

			private string userProject;

			private string logStore;

			private string logDesc;

			private string category;

			private string status;

			public string Project
			{
				get
				{
					return project;
				}
				set	
				{
					project = value;
				}
			}

			public string UserProject
			{
				get
				{
					return userProject;
				}
				set	
				{
					userProject = value;
				}
			}

			public string LogStore
			{
				get
				{
					return logStore;
				}
				set	
				{
					logStore = value;
				}
			}

			public string LogDesc
			{
				get
				{
					return logDesc;
				}
				set	
				{
					logDesc = value;
				}
			}

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
		}
	}
}
