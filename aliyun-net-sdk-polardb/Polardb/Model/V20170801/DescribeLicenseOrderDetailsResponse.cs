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
using Newtonsoft.Json;
using Aliyun.Acs.Core;

namespace Aliyun.Acs.polardb.Model.V20170801
{
	public class DescribeLicenseOrderDetailsResponse : AcsResponse
	{

		private int? activatedCodeCount;

		private int? activationCodeQuota;

		private string aliyunOrderId;

		private bool? allowEmptySystemIdentifier;

		private string engine;

		private string gmtCreated;

		private string gmtModified;

		private bool? isVirtualOrder;

		private bool? isVirtualOrderFrozen;

		private string packageType;

		private string packageValidity;

		private string purchaseChannel;

		private string requestId;

		private string virtualOrderId;

		public int? ActivatedCodeCount
		{
			get
			{
				return activatedCodeCount;
			}
			set	
			{
				activatedCodeCount = value;
			}
		}

		public int? ActivationCodeQuota
		{
			get
			{
				return activationCodeQuota;
			}
			set	
			{
				activationCodeQuota = value;
			}
		}

		public string AliyunOrderId
		{
			get
			{
				return aliyunOrderId;
			}
			set	
			{
				aliyunOrderId = value;
			}
		}

		public bool? AllowEmptySystemIdentifier
		{
			get
			{
				return allowEmptySystemIdentifier;
			}
			set	
			{
				allowEmptySystemIdentifier = value;
			}
		}

		public string Engine
		{
			get
			{
				return engine;
			}
			set	
			{
				engine = value;
			}
		}

		public string GmtCreated
		{
			get
			{
				return gmtCreated;
			}
			set	
			{
				gmtCreated = value;
			}
		}

		public string GmtModified
		{
			get
			{
				return gmtModified;
			}
			set	
			{
				gmtModified = value;
			}
		}

		public bool? IsVirtualOrder
		{
			get
			{
				return isVirtualOrder;
			}
			set	
			{
				isVirtualOrder = value;
			}
		}

		public bool? IsVirtualOrderFrozen
		{
			get
			{
				return isVirtualOrderFrozen;
			}
			set	
			{
				isVirtualOrderFrozen = value;
			}
		}

		public string PackageType
		{
			get
			{
				return packageType;
			}
			set	
			{
				packageType = value;
			}
		}

		public string PackageValidity
		{
			get
			{
				return packageValidity;
			}
			set	
			{
				packageValidity = value;
			}
		}

		public string PurchaseChannel
		{
			get
			{
				return purchaseChannel;
			}
			set	
			{
				purchaseChannel = value;
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

		public string VirtualOrderId
		{
			get
			{
				return virtualOrderId;
			}
			set	
			{
				virtualOrderId = value;
			}
		}
	}
}
