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

namespace Aliyun.Acs.Copyright.Model.V20190123
{
	public class GetUpgradeWorkResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private long? workId;

		private long? createTime;

		private long? modifiedTime;

		private int? workStatus;

		private string reason;

		private string newSku;

		private string oldSku;

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

		public long? WorkId
		{
			get
			{
				return workId;
			}
			set	
			{
				workId = value;
			}
		}

		public long? CreateTime
		{
			get
			{
				return createTime;
			}
			set	
			{
				createTime = value;
			}
		}

		public long? ModifiedTime
		{
			get
			{
				return modifiedTime;
			}
			set	
			{
				modifiedTime = value;
			}
		}

		public int? WorkStatus
		{
			get
			{
				return workStatus;
			}
			set	
			{
				workStatus = value;
			}
		}

		public string Reason
		{
			get
			{
				return reason;
			}
			set	
			{
				reason = value;
			}
		}

		public string NewSku
		{
			get
			{
				return newSku;
			}
			set	
			{
				newSku = value;
			}
		}

		public string OldSku
		{
			get
			{
				return oldSku;
			}
			set	
			{
				oldSku = value;
			}
		}
	}
}
