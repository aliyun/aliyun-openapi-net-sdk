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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.vod.Model.V20170321
{
	public class DescribeVodRefreshQuotaResponse : AcsResponse
	{

		private string requestId;

		private string urlQuota;

		private string dirQuota;

		private string urlRemain;

		private string dirRemain;

		private string preloadQuota;

		private string blockQuota;

		private string preloadRemain;

		private string blockRemain;

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

		public string UrlQuota
		{
			get
			{
				return urlQuota;
			}
			set	
			{
				urlQuota = value;
			}
		}

		public string DirQuota
		{
			get
			{
				return dirQuota;
			}
			set	
			{
				dirQuota = value;
			}
		}

		public string UrlRemain
		{
			get
			{
				return urlRemain;
			}
			set	
			{
				urlRemain = value;
			}
		}

		public string DirRemain
		{
			get
			{
				return dirRemain;
			}
			set	
			{
				dirRemain = value;
			}
		}

		public string PreloadQuota
		{
			get
			{
				return preloadQuota;
			}
			set	
			{
				preloadQuota = value;
			}
		}

		public string BlockQuota
		{
			get
			{
				return blockQuota;
			}
			set	
			{
				blockQuota = value;
			}
		}

		public string PreloadRemain
		{
			get
			{
				return preloadRemain;
			}
			set	
			{
				preloadRemain = value;
			}
		}

		public string BlockRemain
		{
			get
			{
				return blockRemain;
			}
			set	
			{
				blockRemain = value;
			}
		}
	}
}