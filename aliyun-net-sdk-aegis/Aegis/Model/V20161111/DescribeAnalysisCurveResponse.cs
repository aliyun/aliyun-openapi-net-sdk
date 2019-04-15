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
	public class DescribeAnalysisCurveResponse : AcsResponse
	{

		private string requestId;

		private DescribeAnalysisCurve_Curves curves;

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

		public DescribeAnalysisCurve_Curves Curves
		{
			get
			{
				return curves;
			}
			set	
			{
				curves = value;
			}
		}

		public class DescribeAnalysisCurve_Curves
		{

			private List<DescribeAnalysisCurve_OriginalCurve> originalCurveList;

			private List<DescribeAnalysisCurve_ResultCurve> resultCurveList;

			public List<DescribeAnalysisCurve_OriginalCurve> OriginalCurveList
			{
				get
				{
					return originalCurveList;
				}
				set	
				{
					originalCurveList = value;
				}
			}

			public List<DescribeAnalysisCurve_ResultCurve> ResultCurveList
			{
				get
				{
					return resultCurveList;
				}
				set	
				{
					resultCurveList = value;
				}
			}

			public class DescribeAnalysisCurve_OriginalCurve
			{

				private int? count;

				private long? dsTimestamp;

				public int? Count
				{
					get
					{
						return count;
					}
					set	
					{
						count = value;
					}
				}

				public long? DsTimestamp
				{
					get
					{
						return dsTimestamp;
					}
					set	
					{
						dsTimestamp = value;
					}
				}
			}

			public class DescribeAnalysisCurve_ResultCurve
			{

				private int? count;

				private long? dsTimestamp;

				public int? Count
				{
					get
					{
						return count;
					}
					set	
					{
						count = value;
					}
				}

				public long? DsTimestamp
				{
					get
					{
						return dsTimestamp;
					}
					set	
					{
						dsTimestamp = value;
					}
				}
			}
		}
	}
}
