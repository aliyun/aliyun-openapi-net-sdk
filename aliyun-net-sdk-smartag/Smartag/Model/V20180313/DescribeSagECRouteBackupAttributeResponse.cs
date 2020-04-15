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

namespace Aliyun.Acs.Smartag.Model.V20180313
{
	public class DescribeSagECRouteBackupAttributeResponse : AcsResponse
	{

		private string requestId;

		private string sagId;

		private string hcIp;

		private string expressConnectionInterface;

		private string expressConnectionNexthop;

		private bool? routeBackup;

		private string status;

		private List<DescribeSagECRouteBackupAttribute_Cidr> cidrs;

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

		public string SagId
		{
			get
			{
				return sagId;
			}
			set	
			{
				sagId = value;
			}
		}

		public string HcIp
		{
			get
			{
				return hcIp;
			}
			set	
			{
				hcIp = value;
			}
		}

		public string ExpressConnectionInterface
		{
			get
			{
				return expressConnectionInterface;
			}
			set	
			{
				expressConnectionInterface = value;
			}
		}

		public string ExpressConnectionNexthop
		{
			get
			{
				return expressConnectionNexthop;
			}
			set	
			{
				expressConnectionNexthop = value;
			}
		}

		public bool? RouteBackup
		{
			get
			{
				return routeBackup;
			}
			set	
			{
				routeBackup = value;
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

		public List<DescribeSagECRouteBackupAttribute_Cidr> Cidrs
		{
			get
			{
				return cidrs;
			}
			set	
			{
				cidrs = value;
			}
		}

		public class DescribeSagECRouteBackupAttribute_Cidr
		{

			private string cidr;

			private bool? enableBackup;

			public string Cidr
			{
				get
				{
					return cidr;
				}
				set	
				{
					cidr = value;
				}
			}

			public bool? EnableBackup
			{
				get
				{
					return enableBackup;
				}
				set	
				{
					enableBackup = value;
				}
			}
		}
	}
}
