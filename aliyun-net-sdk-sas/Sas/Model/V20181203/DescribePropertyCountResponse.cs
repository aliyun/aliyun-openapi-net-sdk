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

namespace Aliyun.Acs.Sas.Model.V20181203
{
	public class DescribePropertyCountResponse : AcsResponse
	{

		private string requestId;

		private int? port;

		private int? process;

		private int? software;

		private int? user;

		private int? cron;

		private int? sca;

		private int? autoRun;

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

		public int? Port
		{
			get
			{
				return port;
			}
			set	
			{
				port = value;
			}
		}

		public int? Process
		{
			get
			{
				return process;
			}
			set	
			{
				process = value;
			}
		}

		public int? Software
		{
			get
			{
				return software;
			}
			set	
			{
				software = value;
			}
		}

		public int? User
		{
			get
			{
				return user;
			}
			set	
			{
				user = value;
			}
		}

		public int? Cron
		{
			get
			{
				return cron;
			}
			set	
			{
				cron = value;
			}
		}

		public int? Sca
		{
			get
			{
				return sca;
			}
			set	
			{
				sca = value;
			}
		}

		public int? AutoRun
		{
			get
			{
				return autoRun;
			}
			set	
			{
				autoRun = value;
			}
		}
	}
}
