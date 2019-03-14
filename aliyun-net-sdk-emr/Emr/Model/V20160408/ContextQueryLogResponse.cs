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
	public class ContextQueryLogResponse : AcsResponse
	{

		private string requestId;

		private string packId;

		private string packMeta;

		private string time;

		private List<ContextQueryLog_Item> logs;

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

		public string PackId
		{
			get
			{
				return packId;
			}
			set	
			{
				packId = value;
			}
		}

		public string PackMeta
		{
			get
			{
				return packMeta;
			}
			set	
			{
				packMeta = value;
			}
		}

		public string Time
		{
			get
			{
				return time;
			}
			set	
			{
				time = value;
			}
		}

		public List<ContextQueryLog_Item> Logs
		{
			get
			{
				return logs;
			}
			set	
			{
				logs = value;
			}
		}

		public class ContextQueryLog_Item
		{

			private int? index;

			private string content;

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
		}
	}
}
