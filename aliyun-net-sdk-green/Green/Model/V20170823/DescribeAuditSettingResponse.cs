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

namespace Aliyun.Acs.Green.Model.V20170823
{
	public class DescribeAuditSettingResponse : AcsResponse
	{

		private string requestId;

		private string seed;

		private string callback;

		private DescribeAuditSetting_AuditRange auditRange;

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

		public string Seed
		{
			get
			{
				return seed;
			}
			set	
			{
				seed = value;
			}
		}

		public string Callback
		{
			get
			{
				return callback;
			}
			set	
			{
				callback = value;
			}
		}

		public DescribeAuditSetting_AuditRange AuditRange
		{
			get
			{
				return auditRange;
			}
			set	
			{
				auditRange = value;
			}
		}

		public class DescribeAuditSetting_AuditRange
		{

			private bool? pass;

			private bool? block;

			private bool? review;

			public bool? Pass
			{
				get
				{
					return pass;
				}
				set	
				{
					pass = value;
				}
			}

			public bool? Block
			{
				get
				{
					return block;
				}
				set	
				{
					block = value;
				}
			}

			public bool? Review
			{
				get
				{
					return review;
				}
				set	
				{
					review = value;
				}
			}
		}
	}
}
