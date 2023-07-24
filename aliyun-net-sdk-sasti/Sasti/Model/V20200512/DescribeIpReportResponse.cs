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

namespace Aliyun.Acs.Sasti.Model.V20200512
{
	public class DescribeIpReportResponse : AcsResponse
	{

		private string context;

		private string intelligences;

		private string whois;

		private string requestId;

		private string attackPreferenceTop5;

		private string confidence;

		private string threatTypes;

		private string scenario;

		private string ip;

		private string threatLevel;

		private string attackCntByThreatType;

		private string group;

		public string Context
		{
			get
			{
				return context;
			}
			set	
			{
				context = value;
			}
		}

		public string Intelligences
		{
			get
			{
				return intelligences;
			}
			set	
			{
				intelligences = value;
			}
		}

		public string Whois
		{
			get
			{
				return whois;
			}
			set	
			{
				whois = value;
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

		public string AttackPreferenceTop5
		{
			get
			{
				return attackPreferenceTop5;
			}
			set	
			{
				attackPreferenceTop5 = value;
			}
		}

		public string Confidence
		{
			get
			{
				return confidence;
			}
			set	
			{
				confidence = value;
			}
		}

		public string ThreatTypes
		{
			get
			{
				return threatTypes;
			}
			set	
			{
				threatTypes = value;
			}
		}

		public string Scenario
		{
			get
			{
				return scenario;
			}
			set	
			{
				scenario = value;
			}
		}

		public string Ip
		{
			get
			{
				return ip;
			}
			set	
			{
				ip = value;
			}
		}

		public string ThreatLevel
		{
			get
			{
				return threatLevel;
			}
			set	
			{
				threatLevel = value;
			}
		}

		public string AttackCntByThreatType
		{
			get
			{
				return attackCntByThreatType;
			}
			set	
			{
				attackCntByThreatType = value;
			}
		}

		public string Group
		{
			get
			{
				return group;
			}
			set	
			{
				group = value;
			}
		}
	}
}
