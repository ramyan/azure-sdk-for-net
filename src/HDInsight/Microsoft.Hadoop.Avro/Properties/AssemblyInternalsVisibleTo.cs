﻿// /********************************************************
// *                                                       *
// *   Copyright (C) Microsoft. All rights reserved.       *
// *                                                       *
// ********************************************************/

using System.Runtime.CompilerServices;

#if DEVSIGNED                                                         
[assembly: InternalsVisibleTo("Microsoft.Hadoop.Avro.Tests, PublicKey=00240000048000009400000006020000002400005253413100040000010001002592552baf0c4819857c12145baeaea2e7191d00874d9df03d9b3deec1efcca0ae56fbcba8e8aea60c29c84e7679269e020c32c7efd5cd93a821caa0d0e9a7247623396cc1c280133caefcc8d585901f709ba3fbd96628e6554678b7b1dcc446748433b00599efdb447cb8fd35ef318be24fe5728fe14fcfb67b85197c049fdb")]
#elif OFFICIALSIGNED
[assembly: InternalsVisibleTo("Microsoft.Hadoop.Avro.Tests, PublicKey=0024000004800000940000000602000000240000525341310004000001000100b5fc90e7027f67871e773a8fde8938c81dd402ba65b9201d60593e96c492651e889cc13f1415ebb53fac1131ae0bd333c5ee6021672d9718ea31a8aebd0da0072f25d87dba6fc90ffd598ed4da35e44c398c454307e8e33b8426143daec9f596836f97c8f74750e5975c64e2189f45def46b2a2b1247adc3652bf5c308055da9")]
#else
[assembly: InternalsVisibleTo("Microsoft.Hadoop.Avro.Tests, PublicKey=00240000048000009400000006020000002400005253413100040000010001002592552baf0c4819857c12145baeaea2e7191d00874d9df03d9b3deec1efcca0ae56fbcba8e8aea60c29c84e7679269e020c32c7efd5cd93a821caa0d0e9a7247623396cc1c280133caefcc8d585901f709ba3fbd96628e6554678b7b1dcc446748433b00599efdb447cb8fd35ef318be24fe5728fe14fcfb67b85197c049fdb")]
#endif
