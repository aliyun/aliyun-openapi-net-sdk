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

namespace Aliyun.Acs.dcdn.Model.V20180115
{
	public class DescribeDcdnUserQuotaResponse : AcsResponse
	{

		private string requestId;

		private int? domainQuota;

		private int? refreshUrlQuota;

		private int? refreshDirQuota;

		private int? refreshUrlRemain;

		private int? refreshDirRemain;

		private int? preloadQuota;

		private int? preloadRemain;

		private int? blockQuota;

		private int? blockRemain;

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

		public int? DomainQuota
		{
			get
			{
				return domainQuota;
			}
			set	
			{
				domainQuota = value;
			}
		}

		public int? RefreshUrlQuota
		{
			get
			{
				return refreshUrlQuota;
			}
			set	
			{
				refreshUrlQuota = value;
			}
		}

		public int? RefreshDirQuota
		{
			get
			{
				return refreshDirQuota;
			}
			set	
			{
				refreshDirQuota = value;
			}
		}

		public int? RefreshUrlRemain
		{
			get
			{
				return refreshUrlRemain;
			}
			set	
			{
				refreshUrlRemain = value;
			}
		}

		public int? RefreshDirRemain
		{
			get
			{
				return refreshDirRemain;
			}
			set	
			{
				refreshDirRemain = value;
			}
		}

		public int? PreloadQuota
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

		public int? PreloadRemain
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

		public int? BlockQuota
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

		public int? BlockRemain
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
