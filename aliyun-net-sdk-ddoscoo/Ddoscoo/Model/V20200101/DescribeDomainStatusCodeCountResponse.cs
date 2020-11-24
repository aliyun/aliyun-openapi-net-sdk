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

namespace Aliyun.Acs.ddoscoo.Model.V20200101
{
	public class DescribeDomainStatusCodeCountResponse : AcsResponse
	{

		private string requestId;

		private long? status2XX;

		private long? status501;

		private long? status502;

		private long? status503;

		private long? status504;

		private long? status200;

		private long? status405;

		private long? status5XX;

		private long? status4XX;

		private long? status403;

		private long? status404;

		private long? status3XX;

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

		public long? Status2XX
		{
			get
			{
				return status2XX;
			}
			set	
			{
				status2XX = value;
			}
		}

		public long? Status501
		{
			get
			{
				return status501;
			}
			set	
			{
				status501 = value;
			}
		}

		public long? Status502
		{
			get
			{
				return status502;
			}
			set	
			{
				status502 = value;
			}
		}

		public long? Status503
		{
			get
			{
				return status503;
			}
			set	
			{
				status503 = value;
			}
		}

		public long? Status504
		{
			get
			{
				return status504;
			}
			set	
			{
				status504 = value;
			}
		}

		public long? Status200
		{
			get
			{
				return status200;
			}
			set	
			{
				status200 = value;
			}
		}

		public long? Status405
		{
			get
			{
				return status405;
			}
			set	
			{
				status405 = value;
			}
		}

		public long? Status5XX
		{
			get
			{
				return status5XX;
			}
			set	
			{
				status5XX = value;
			}
		}

		public long? Status4XX
		{
			get
			{
				return status4XX;
			}
			set	
			{
				status4XX = value;
			}
		}

		public long? Status403
		{
			get
			{
				return status403;
			}
			set	
			{
				status403 = value;
			}
		}

		public long? Status404
		{
			get
			{
				return status404;
			}
			set	
			{
				status404 = value;
			}
		}

		public long? Status3XX
		{
			get
			{
				return status3XX;
			}
			set	
			{
				status3XX = value;
			}
		}
	}
}
