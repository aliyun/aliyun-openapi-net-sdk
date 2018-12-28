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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.imm.Model.V20170906
{
	public class CompareImageFacesResponse : AcsResponse
	{

		private string requestId;

		private string setId;

		private float? similarity;

		private CompareImageFaces_FaceA faceA;

		private CompareImageFaces_FaceB faceB;

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

		public string SetId
		{
			get
			{
				return setId;
			}
			set	
			{
				setId = value;
			}
		}

		public float? Similarity
		{
			get
			{
				return similarity;
			}
			set	
			{
				similarity = value;
			}
		}

		public CompareImageFaces_FaceA FaceA
		{
			get
			{
				return faceA;
			}
			set	
			{
				faceA = value;
			}
		}

		public CompareImageFaces_FaceB FaceB
		{
			get
			{
				return faceB;
			}
			set	
			{
				faceB = value;
			}
		}

		public class CompareImageFaces_FaceA
		{

			private string faceId;

			private CompareImageFaces_FaceAttributes faceAttributes;

			public string FaceId
			{
				get
				{
					return faceId;
				}
				set	
				{
					faceId = value;
				}
			}

			public CompareImageFaces_FaceAttributes FaceAttributes
			{
				get
				{
					return faceAttributes;
				}
				set	
				{
					faceAttributes = value;
				}
			}

			public class CompareImageFaces_FaceAttributes
			{

				private CompareImageFaces_FaceBoundary faceBoundary;

				public CompareImageFaces_FaceBoundary FaceBoundary
				{
					get
					{
						return faceBoundary;
					}
					set	
					{
						faceBoundary = value;
					}
				}

				public class CompareImageFaces_FaceBoundary
				{

					private int? left;

					private int? top;

					private int? width;

					private int? height;

					public int? Left
					{
						get
						{
							return left;
						}
						set	
						{
							left = value;
						}
					}

					public int? Top
					{
						get
						{
							return top;
						}
						set	
						{
							top = value;
						}
					}

					public int? Width
					{
						get
						{
							return width;
						}
						set	
						{
							width = value;
						}
					}

					public int? Height
					{
						get
						{
							return height;
						}
						set	
						{
							height = value;
						}
					}
				}
			}
		}

		public class CompareImageFaces_FaceB
		{

			private string faceId;

			private CompareImageFaces_FaceAttributes1 faceAttributes1;

			public string FaceId
			{
				get
				{
					return faceId;
				}
				set	
				{
					faceId = value;
				}
			}

			public CompareImageFaces_FaceAttributes1 FaceAttributes1
			{
				get
				{
					return faceAttributes1;
				}
				set	
				{
					faceAttributes1 = value;
				}
			}

			public class CompareImageFaces_FaceAttributes1
			{

				private CompareImageFaces_FaceBoundary2 faceBoundary2;

				public CompareImageFaces_FaceBoundary2 FaceBoundary2
				{
					get
					{
						return faceBoundary2;
					}
					set	
					{
						faceBoundary2 = value;
					}
				}

				public class CompareImageFaces_FaceBoundary2
				{

					private int? left;

					private int? top;

					private int? width;

					private int? height;

					public int? Left
					{
						get
						{
							return left;
						}
						set	
						{
							left = value;
						}
					}

					public int? Top
					{
						get
						{
							return top;
						}
						set	
						{
							top = value;
						}
					}

					public int? Width
					{
						get
						{
							return width;
						}
						set	
						{
							width = value;
						}
					}

					public int? Height
					{
						get
						{
							return height;
						}
						set	
						{
							height = value;
						}
					}
				}
			}
		}
	}
}