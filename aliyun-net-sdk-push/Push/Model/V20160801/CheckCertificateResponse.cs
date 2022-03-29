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

namespace Aliyun.Acs.Push.Model.V20160801
{
	public class CheckCertificateResponse : AcsResponse
	{

		private string requestId;

		private bool? android;

		private bool? iOS;

		private CheckCertificate_ProductionCertInfo productionCertInfo;

		private CheckCertificate_DevelopmentCertInfo developmentCertInfo;

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

		public bool? Android
		{
			get
			{
				return android;
			}
			set	
			{
				android = value;
			}
		}

		public bool? IOS
		{
			get
			{
				return iOS;
			}
			set	
			{
				iOS = value;
			}
		}

		public CheckCertificate_ProductionCertInfo ProductionCertInfo
		{
			get
			{
				return productionCertInfo;
			}
			set	
			{
				productionCertInfo = value;
			}
		}

		public CheckCertificate_DevelopmentCertInfo DevelopmentCertInfo
		{
			get
			{
				return developmentCertInfo;
			}
			set	
			{
				developmentCertInfo = value;
			}
		}

		public class CheckCertificate_ProductionCertInfo
		{

			private string status;

			private long? exipreTime;

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

			public long? ExipreTime
			{
				get
				{
					return exipreTime;
				}
				set	
				{
					exipreTime = value;
				}
			}
		}

		public class CheckCertificate_DevelopmentCertInfo
		{

			private string status;

			private long? exipreTime;

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

			public long? ExipreTime
			{
				get
				{
					return exipreTime;
				}
				set	
				{
					exipreTime = value;
				}
			}
		}
	}
}
