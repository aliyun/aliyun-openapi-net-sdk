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

namespace Aliyun.Acs.HBase.Model.V20190101
{
	public class DescribeColdStorageResponse : AcsResponse
	{

		private string requestId;

		private string clusterId;

		private string openStatus;

		private string coldStorageSize;

		private string coldStorageUsePercent;

		private string payType;

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

		public string ClusterId
		{
			get
			{
				return clusterId;
			}
			set	
			{
				clusterId = value;
			}
		}

		public string OpenStatus
		{
			get
			{
				return openStatus;
			}
			set	
			{
				openStatus = value;
			}
		}

		public string ColdStorageSize
		{
			get
			{
				return coldStorageSize;
			}
			set	
			{
				coldStorageSize = value;
			}
		}

		public string ColdStorageUsePercent
		{
			get
			{
				return coldStorageUsePercent;
			}
			set	
			{
				coldStorageUsePercent = value;
			}
		}

		public string PayType
		{
			get
			{
				return payType;
			}
			set	
			{
				payType = value;
			}
		}
	}
}
