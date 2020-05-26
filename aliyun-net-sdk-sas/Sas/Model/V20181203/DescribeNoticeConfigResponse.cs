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

namespace Aliyun.Acs.Sas.Model.V20181203
{
	public class DescribeNoticeConfigResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeNoticeConfig_NoticeConfig> noticeConfigList;

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

		public List<DescribeNoticeConfig_NoticeConfig> NoticeConfigList
		{
			get
			{
				return noticeConfigList;
			}
			set	
			{
				noticeConfigList = value;
			}
		}

		public class DescribeNoticeConfig_NoticeConfig
		{

			private int? timeLimit;

			private int? route;

			private string project;

			private long? aliUid;

			private int? currentPage;

			public int? TimeLimit
			{
				get
				{
					return timeLimit;
				}
				set	
				{
					timeLimit = value;
				}
			}

			public int? Route
			{
				get
				{
					return route;
				}
				set	
				{
					route = value;
				}
			}

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

			public long? AliUid
			{
				get
				{
					return aliUid;
				}
				set	
				{
					aliUid = value;
				}
			}

			public int? CurrentPage
			{
				get
				{
					return currentPage;
				}
				set	
				{
					currentPage = value;
				}
			}
		}
	}
}
