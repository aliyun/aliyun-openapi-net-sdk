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

namespace Aliyun.Acs.aegis.Model.V20161111
{
	public class DescribeDefenceThreadResponse : AcsResponse
	{

		private string requestId;

		private int? defenceCountTotal;

		private int? tamperProofTotal;

		private List<string> defenceAaggregatCountArray;

		private List<string> tamperProofArray;

		private List<string> dateArray;

		private List<string> tamperProofAaggregateArray;

		private List<string> defenceCountArray;

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

		public int? DefenceCountTotal
		{
			get
			{
				return defenceCountTotal;
			}
			set	
			{
				defenceCountTotal = value;
			}
		}

		public int? TamperProofTotal
		{
			get
			{
				return tamperProofTotal;
			}
			set	
			{
				tamperProofTotal = value;
			}
		}

		public List<string> DefenceAaggregatCountArray
		{
			get
			{
				return defenceAaggregatCountArray;
			}
			set	
			{
				defenceAaggregatCountArray = value;
			}
		}

		public List<string> TamperProofArray
		{
			get
			{
				return tamperProofArray;
			}
			set	
			{
				tamperProofArray = value;
			}
		}

		public List<string> DateArray
		{
			get
			{
				return dateArray;
			}
			set	
			{
				dateArray = value;
			}
		}

		public List<string> TamperProofAaggregateArray
		{
			get
			{
				return tamperProofAaggregateArray;
			}
			set	
			{
				tamperProofAaggregateArray = value;
			}
		}

		public List<string> DefenceCountArray
		{
			get
			{
				return defenceCountArray;
			}
			set	
			{
				defenceCountArray = value;
			}
		}
	}
}
