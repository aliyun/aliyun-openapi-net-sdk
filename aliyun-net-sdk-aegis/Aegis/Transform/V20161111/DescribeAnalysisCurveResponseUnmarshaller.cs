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
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.aegis.Model.V20161111;

namespace Aliyun.Acs.aegis.Transform.V20161111
{
    public class DescribeAnalysisCurveResponseUnmarshaller
    {
        public static DescribeAnalysisCurveResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeAnalysisCurveResponse describeAnalysisCurveResponse = new DescribeAnalysisCurveResponse();

			describeAnalysisCurveResponse.HttpResponse = context.HttpResponse;
			describeAnalysisCurveResponse.RequestId = context.StringValue("DescribeAnalysisCurve.RequestId");

			DescribeAnalysisCurveResponse.DescribeAnalysisCurve_Curves curves = new DescribeAnalysisCurveResponse.DescribeAnalysisCurve_Curves();

			List<DescribeAnalysisCurveResponse.DescribeAnalysisCurve_Curves.DescribeAnalysisCurve_OriginalCurve> curves_originalCurveList = new List<DescribeAnalysisCurveResponse.DescribeAnalysisCurve_Curves.DescribeAnalysisCurve_OriginalCurve>();
			for (int i = 0; i < context.Length("DescribeAnalysisCurve.Curves.OriginalCurveList.Length"); i++) {
				DescribeAnalysisCurveResponse.DescribeAnalysisCurve_Curves.DescribeAnalysisCurve_OriginalCurve originalCurve = new DescribeAnalysisCurveResponse.DescribeAnalysisCurve_Curves.DescribeAnalysisCurve_OriginalCurve();
				originalCurve.Count = context.IntegerValue("DescribeAnalysisCurve.Curves.OriginalCurveList["+ i +"].Count");
				originalCurve.DsTimestamp = context.LongValue("DescribeAnalysisCurve.Curves.OriginalCurveList["+ i +"].DsTimestamp");

				curves_originalCurveList.Add(originalCurve);
			}
			curves.OriginalCurveList = curves_originalCurveList;

			List<DescribeAnalysisCurveResponse.DescribeAnalysisCurve_Curves.DescribeAnalysisCurve_ResultCurve> curves_resultCurveList = new List<DescribeAnalysisCurveResponse.DescribeAnalysisCurve_Curves.DescribeAnalysisCurve_ResultCurve>();
			for (int i = 0; i < context.Length("DescribeAnalysisCurve.Curves.ResultCurveList.Length"); i++) {
				DescribeAnalysisCurveResponse.DescribeAnalysisCurve_Curves.DescribeAnalysisCurve_ResultCurve resultCurve = new DescribeAnalysisCurveResponse.DescribeAnalysisCurve_Curves.DescribeAnalysisCurve_ResultCurve();
				resultCurve.Count = context.IntegerValue("DescribeAnalysisCurve.Curves.ResultCurveList["+ i +"].Count");
				resultCurve.DsTimestamp = context.LongValue("DescribeAnalysisCurve.Curves.ResultCurveList["+ i +"].DsTimestamp");

				curves_resultCurveList.Add(resultCurve);
			}
			curves.ResultCurveList = curves_resultCurveList;
			describeAnalysisCurveResponse.Curves = curves;
        
			return describeAnalysisCurveResponse;
        }
    }
}
